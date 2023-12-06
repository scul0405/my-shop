package repository

import (
	"context"
	"database/sql"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/book"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"github.com/volatiletech/sqlboiler/v4/boil"
	"github.com/volatiletech/sqlboiler/v4/queries/qm"
)

type bookRepo struct {
	db *sqlx.DB
}

func NewBookRepo(db *sqlx.DB) book.Repository {
	return &bookRepo{
		db: db,
	}
}

func (r *bookRepo) Create(ctx context.Context, book *dbmodels.Book) (*dbmodels.Book, error) {
	if err := book.Insert(ctx, r.db, boil.Blacklist("id")); err != nil {
		return nil, err
	}

	return book, nil
}

func (r *bookRepo) GetByID(ctx context.Context, id uint64) (*dbmodels.Book, error) {
	bookModel, err := dbmodels.FindBook(ctx, r.db, int64(id))
	if err != nil {
		return nil, err
	}

	return bookModel, nil
}

func (r *bookRepo) Update(ctx context.Context, book *dbmodels.Book, whiteList ...string) error {

	rowAffect, err := book.Update(ctx, r.db, boil.Whitelist(whiteList...))
	if rowAffect == 0 {
		return sql.ErrNoRows
	}
	if err != nil {
		return err
	}

	return nil
}

func (r *bookRepo) Delete(ctx context.Context, id uint64) error {
	rowAffect, err := dbmodels.Books(dbmodels.BookWhere.ID.EQ(int64(id))).DeleteAll(ctx, r.db)
	if rowAffect == 0 {
		return sql.ErrNoRows
	}
	if err != nil {
		return err
	}

	return nil
}

func (r *bookRepo) List(ctx context.Context, pq *utils.PaginationQuery, qms ...qm.QueryMod) (*utils.PaginationList, error) {
	countAll, err := dbmodels.Books(qms...).Count(ctx, r.db)
	if err != nil {
		return nil, err
	}

	totalCount := int(countAll)
	if totalCount == 0 {
		return &utils.PaginationList{
			TotalCount: totalCount,
			TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
			Page:       pq.GetPage(),
			Size:       pq.GetSize(),
			HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
			List:       make(dbmodels.BookSlice, 0),
		}, nil
	}

	// TODO: update order by
	qms = append(qms, qm.Limit(pq.GetLimit()), qm.Offset(pq.GetOffset()))
	bookList, err := dbmodels.Books(qms...).All(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return &utils.PaginationList{
		TotalCount: totalCount,
		TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
		Page:       pq.GetPage(),
		Size:       pq.GetSize(),
		HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
		List:       bookList,
	}, nil
}

func (r *bookRepo) ListByCategoryName(ctx context.Context, pq *utils.PaginationQuery, categoryName string) (*utils.PaginationList, error) {
	type BookAndCategory struct {
		dbmodels.Book         `boil:",bind"`
		dbmodels.BookCategory `boil:",bind"`
		Count                 int `boil:"count"`
	}

	var (
		countAll            BookAndCategory
		bookAndCategoryList []*BookAndCategory
		err                 error
	)

	err = dbmodels.NewQuery(
		qm.Select("count(*) as count"),
		qm.From("books"),
		qm.InnerJoin("book_categories on books.category_id = book_categories.id"),
		qm.Where("book_categories.name = ?", categoryName),
	).Bind(ctx, r.db, &countAll)
	if err != nil {
		return nil, err
	}

	totalCount := countAll.Count
	if totalCount == 0 {
		return &utils.PaginationList{
			TotalCount: totalCount,
			TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
			Page:       pq.GetPage(),
			Size:       pq.GetSize(),
			HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
			List:       make(dbmodels.BookSlice, 0),
		}, nil
	}

	err = dbmodels.NewQuery(
		qm.Select("books.*"),
		qm.From("books"),
		qm.InnerJoin("book_categories on books.category_id = book_categories.id"),
		qm.Where("book_categories.name = ?", categoryName),
		qm.Limit(pq.GetLimit()),
		qm.Offset(pq.GetOffset()),
	).Bind(ctx, r.db, &bookAndCategoryList)
	if err != nil {
		return nil, err
	}

	// Convert to book list
	var bookList dbmodels.BookSlice
	for _, bookAndCategory := range bookAndCategoryList {
		bookList = append(bookList, &bookAndCategory.Book)
	}

	return &utils.PaginationList{
		TotalCount: totalCount,
		TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
		Page:       pq.GetPage(),
		Size:       pq.GetSize(),
		HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
		List:       bookList,
	}, nil
}

func (r *bookRepo) GetByOrderID(ctx context.Context, id uint64) (dbmodels.BookSlice, error) {
	books, err := dbmodels.Books(
		qm.Select("*"),
		qm.InnerJoin("book_order ON book_order.book_id = books.id"),
		qm.InnerJoin("orders ON orders.id = book_order.order_id"),
		qm.Where("orders.id = ?", id),
	).All(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return books, nil
}

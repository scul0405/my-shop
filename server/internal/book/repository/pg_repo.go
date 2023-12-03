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

func (r *bookRepo) List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error) {
	countAll, err := dbmodels.Books().Count(ctx, r.db)
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
			List:       make([]*dbmodels.Book, 0),
		}, nil
	}

	// TODO: update order by
	bookList, err := dbmodels.Books(qm.Limit(pq.GetLimit()), qm.Offset(pq.GetOffset())).All(ctx, r.db)
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

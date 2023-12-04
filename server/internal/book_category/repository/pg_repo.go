package repository

import (
	"context"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	bookcategory "github.com/scul0405/my-shop/server/internal/book_category"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"github.com/volatiletech/sqlboiler/v4/boil"
	"github.com/volatiletech/sqlboiler/v4/queries/qm"
)

type bookCategoryRepo struct {
	db *sqlx.DB
}

func NewBookCategoryRepo(db *sqlx.DB) bookcategory.Repository {
	return &bookCategoryRepo{
		db: db,
	}
}

func (r *bookCategoryRepo) Create(ctx context.Context, bc *dbmodels.BookCategory) (*dbmodels.BookCategory, error) {
	if err := bc.Insert(ctx, r.db, boil.Blacklist("id")); err != nil {
		return nil, err
	}

	return bc, nil
}

func (r *bookCategoryRepo) List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error) {
	countAll, err := dbmodels.BookCategories().Count(ctx, r.db)
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
			List:       make(dbmodels.BookCategorySlice, 0),
		}, nil
	}

	bcList, err := dbmodels.BookCategories(qm.Limit(pq.GetLimit()), qm.Offset(pq.GetOffset())).All(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return &utils.PaginationList{
		TotalCount: totalCount,
		TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
		Page:       pq.GetPage(),
		Size:       pq.GetSize(),
		HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
		List:       bcList,
	}, nil
}

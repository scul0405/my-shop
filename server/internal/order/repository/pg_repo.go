package repository

import (
	"context"
	"database/sql"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/order"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"github.com/volatiletech/sqlboiler/v4/boil"
	"github.com/volatiletech/sqlboiler/v4/queries/qm"
)

type orderRepo struct {
	db *sqlx.DB
}

func NewOrderRepo(db *sqlx.DB) order.Repository {
	return &orderRepo{
		db: db,
	}
}

func (r *orderRepo) Create(ctx context.Context, order *dbmodels.Order) (*dbmodels.Order, error) {
	if err := order.Insert(ctx, r.db, boil.Blacklist("id")); err != nil {
		return nil, err
	}

	return order, nil
}

func (r *orderRepo) AddBook(ctx context.Context, bookOrder *dbmodels.BookOrder) error {

	if err := bookOrder.Insert(ctx, r.db, boil.Infer()); err != nil {
		return err
	}

	return nil
}

func (r *orderRepo) GetByID(ctx context.Context, id uint64) (*dbmodels.Order, error) {
	orderModel, err := dbmodels.FindOrder(ctx, r.db, int64(id))
	if err != nil {
		return nil, err
	}

	return orderModel, nil
}

func (r *orderRepo) Update(ctx context.Context, order *dbmodels.Order, whiteList ...string) error {
	rowAffect, err := order.Update(ctx, r.db, boil.Whitelist(whiteList...))
	if rowAffect == 0 {
		return sql.ErrNoRows
	}
	if err != nil {
		return err
	}

	return nil
}

func (r *orderRepo) Delete(ctx context.Context, id uint64) error {
	rowAffect, err := dbmodels.Orders(dbmodels.OrderWhere.ID.EQ(int64(id))).DeleteAll(ctx, r.db)
	if rowAffect == 0 {
		return sql.ErrNoRows
	}
	if err != nil {
		return err
	}

	return nil
}

func (r *orderRepo) List(ctx context.Context, pq *utils.PaginationQuery, qms ...qm.QueryMod) (*utils.PaginationList, error) {
	countAll, err := dbmodels.Orders(qms...).Count(ctx, r.db)
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
			List:       make(dbmodels.OrderSlice, 0),
		}, nil
	}

	qms = append(qms, qm.Limit(pq.GetLimit()), qm.Offset(pq.GetOffset()))
	orderList, err := dbmodels.Orders(qms...).All(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return &utils.PaginationList{
		TotalCount: totalCount,
		TotalPages: utils.GetTotalPages(totalCount, pq.GetSize()),
		Page:       pq.GetPage(),
		Size:       pq.GetSize(),
		HasMore:    utils.GetHasMore(pq.GetPage(), totalCount, pq.GetSize()),
		List:       orderList,
	}, nil
}

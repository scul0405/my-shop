package repository

import (
	"context"
	"database/sql"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	bookorder "github.com/scul0405/my-shop/server/internal/book_order"
	"github.com/volatiletech/sqlboiler/v4/boil"
)

type bookOrderRepo struct {
	db *sqlx.DB
}

func NewBookOrderRepo(db *sqlx.DB) bookorder.Repository {
	return &bookOrderRepo{
		db: db,
	}
}

func (r *bookOrderRepo) Get(ctx context.Context, bid uint64, oid uint64) (*dbmodels.BookOrder, error) {
	bc, err := dbmodels.BookOrders(dbmodels.BookOrderWhere.BookID.EQ(int64(bid)), dbmodels.BookOrderWhere.OrderID.EQ(int64(oid))).One(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return bc, nil
}

func (r *bookOrderRepo) Create(ctx context.Context, bookOrder *dbmodels.BookOrder) error {

	if err := bookOrder.Insert(ctx, r.db, boil.Infer()); err != nil {
		return err
	}

	return nil
}

func (r *bookOrderRepo) Update(ctx context.Context, bookOrder *dbmodels.BookOrder) error {
	_, err := bookOrder.Update(ctx, r.db, boil.Infer())
	return err
}

func (r *bookOrderRepo) Delete(ctx context.Context, bid uint64, oid uint64) error {
	bc := &dbmodels.BookOrder{
		BookID:  int64(bid),
		OrderID: int64(oid),
	}

	_, err := bc.Delete(ctx, r.db)
	return err
}

func (r *bookOrderRepo) DeleteByOrderID(ctx context.Context, id uint64) error {
	rowAffect, err := dbmodels.BookOrders(dbmodels.BookOrderWhere.OrderID.EQ(int64(id))).DeleteAll(ctx, r.db)
	if rowAffect == 0 {
		return sql.ErrNoRows
	}

	if err != nil {
		return err
	}

	return nil
}

package bookorder

import (
	"context"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
)

type Repository interface {
	Get(ctx context.Context, bid, oid uint64) (*dbmodels.BookOrder, error)
	Create(ctx context.Context, book *dbmodels.BookOrder) error
	Update(ctx context.Context, book *dbmodels.BookOrder) error
	Delete(ctx context.Context, bid, oid uint64) error
	DeleteByOrderID(ctx context.Context, orderID uint64) error
}

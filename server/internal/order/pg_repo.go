package order

import (
	"context"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type Repository interface {
	Create(ctx context.Context, order *dbmodels.Order) (*dbmodels.Order, error)
	GetByID(ctx context.Context, id uint64) (*dbmodels.Order, error)
	Update(ctx context.Context, order *dbmodels.Order, whiteList ...string) error
	Delete(ctx context.Context, id uint64) error
	List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error)
}

package bookcategory

import (
	"context"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type Repository interface {
	Create(ctx context.Context, book *dbmodels.BookCategory) (*dbmodels.BookCategory, error)
	List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error)
}

package order

import (
	"context"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type UseCase interface {
	Create(ctx context.Context, order *dto.CreateOrderDTO) (*dto.OrderDTO, error)
	AddBook(ctx context.Context, oid, bid uint64, data *dto.CreateBookOrderDTO) error
	GetByID(ctx context.Context, id uint64) (*dto.OrderDTO, error)
	Update(ctx context.Context, blog *dto.UpdateOrderDTO) error
	Delete(ctx context.Context, id uint64) error
	List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error)
}

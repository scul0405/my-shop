package book

import (
	"context"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type UseCase interface {
	Create(ctx context.Context, book *dto.BookDTO) (*dto.BookDTO, error)
	GetByID(ctx context.Context, id uint64) (*dto.BookDTO, error)
	Update(ctx context.Context, blog *dto.BookDTO) error
	Delete(ctx context.Context, id uint64) error
	List(ctx context.Context, pq *utils.PaginationQuery, categoryName string) (*utils.PaginationList, error)
}

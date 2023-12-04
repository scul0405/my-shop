package bookcategory

import (
	"context"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type UseCase interface {
	Create(ctx context.Context, bc *dto.BookCategoryDTO) (*dto.BookCategoryDTO, error)
	List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error)
}

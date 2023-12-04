package usecase

import (
	"context"
	"github.com/scul0405/my-shop/server/config"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	bookcategory "github.com/scul0405/my-shop/server/internal/book_category"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
)

type bookCategoryUseCase struct {
	cfg    *config.Config
	bcRepo bookcategory.Repository
	logger logger.Logger
}

func NewBookCategoryUseCase(
	cfg *config.Config,
	bcRepo bookcategory.Repository,
	logger logger.Logger) bookcategory.UseCase {
	return &bookCategoryUseCase{cfg: cfg, bcRepo: bcRepo, logger: logger}
}

func (u *bookCategoryUseCase) Create(ctx context.Context, bc *dto.BookCategoryDTO) (*dto.BookCategoryDTO, error) {
	createdBookCategory, err := u.bcRepo.Create(ctx, bc.ToModel())
	if err != nil {
		return nil, err
	}

	return bookCategoryModelToDto(createdBookCategory), nil
}

func (u *bookCategoryUseCase) List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error) {
	var (
		paginationList *utils.PaginationList
		err            error
		bcsDTO         []*dto.BookCategoryDTO
	)

	paginationList, err = u.bcRepo.List(ctx, pq)

	if err != nil {
		return nil, err
	}

	for _, bcModel := range paginationList.List.(dbmodels.BookCategorySlice) {
		bcsDTO = append(bcsDTO, bookCategoryModelToDto(bcModel))
	}

	paginationList.List = bcsDTO

	return paginationList, nil
}

func bookCategoryModelToDto(bc *dbmodels.BookCategory) *dto.BookCategoryDTO {
	return &dto.BookCategoryDTO{
		ID:   bc.ID,
		Name: bc.Name,
	}
}

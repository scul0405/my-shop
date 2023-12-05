package dbconverter

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
)

func BookCategoryModelToDto(bc *dbmodels.BookCategory) *dto.BookCategoryDTO {
	return &dto.BookCategoryDTO{
		ID:   uint64(bc.ID),
		Name: bc.Name,
	}
}

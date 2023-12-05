package dbconverter

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
)

func BookModelToDto(book *dbmodels.Book) *dto.BookDTO {
	return &dto.BookDTO{
		ID:         uint64(book.ID),
		CategoryID: uint64(book.CategoryID),
		Name:       book.Name,
		SKU:        book.Sku,
		Desc:       book.Desc.String,
		Image:      book.Image.String,
		Price:      book.Price,
		TotalSold:  book.TotalSold,
		Quantity:   book.Quantity,
		Status:     book.Status,
	}
}

package dbconverter

import (
	customdbmodels "github.com/scul0405/my-shop/server/db/customModels"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
)

func BookModelToDto(book *dbmodels.Book) *dto.BookDTO {
	return &dto.BookDTO{
		ID:         uint64(book.ID),
		CategoryID: uint64(book.CategoryID),
		Name:       book.Name,
		Author:     book.Author,
		Desc:       book.Desc.String,
		Price:      book.Price,
		TotalSold:  book.TotalSold,
		Quantity:   book.Quantity,
		Status:     book.Status,
	}
}

func BookInOrderModelToDto(book *customdbmodels.BookInOrder) *dto.BookInOrderDTO {
	return &dto.BookInOrderDTO{
		ID:            uint64(book.ID),
		CategoryID:    uint64(book.CategoryID),
		Name:          book.Name,
		Author:        book.Author,
		Desc:          book.Desc.String,
		Price:         book.Price,
		TotalSold:     book.TotalSold,
		OrderQuantity: book.OrderQuantity,
		Quantity:      book.Quantity,
		Status:        book.Status,
	}
}

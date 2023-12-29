package dto

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/volatiletech/null/v8"
)

type BookDTO struct {
	ID         uint64 `json:"ID,omitempty"`
	CategoryID uint64 `json:"category_id,omitempty"`
	Name       string `json:"name,omitempty"`
	Author     string `json:"author,omitempty"`
	Desc       string `json:"desc,omitempty"`
	Price      int    `json:"price,omitempty"`
	TotalSold  int    `json:"total_sold,omitempty"`
	Quantity   int    `json:"quantity,omitempty"`
	Status     bool   `json:"status,omitempty"`
}

func (b *BookDTO) ToModel() *dbmodels.Book {
	nullStrDesc := null.String{String: b.Desc, Valid: b.Desc != ""}

	return &dbmodels.Book{
		ID:         int64(b.ID),
		CategoryID: int64(b.CategoryID),
		Name:       b.Name,
		Author:     b.Author,
		Desc:       nullStrDesc,
		Price:      b.Price,
		TotalSold:  b.TotalSold,
		Quantity:   b.Quantity,
		Status:     b.Status,
	}
}

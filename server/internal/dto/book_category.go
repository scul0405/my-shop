package dto

import dbmodels "github.com/scul0405/my-shop/server/db/models"

type BookCategoryDTO struct {
	ID   uint64 `json:"id"`
	Name string `json:"name"`
}

func (b *BookCategoryDTO) ToModel() *dbmodels.BookCategory {
	return &dbmodels.BookCategory{
		ID:   int64(b.ID),
		Name: b.Name,
	}
}

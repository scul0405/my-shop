package dto

import dbmodels "github.com/scul0405/my-shop/server/db/models"

type BookCategoryDTO struct {
	ID   int64  `json:"id"`
	Name string `json:"name"`
}

func (b *BookCategoryDTO) ToModel() *dbmodels.BookCategory {
	return &dbmodels.BookCategory{
		ID:   b.ID,
		Name: b.Name,
	}
}

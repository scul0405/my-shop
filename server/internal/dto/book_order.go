package dto

import dbmodels "github.com/scul0405/my-shop/server/db/models"

type BookOrderDTO struct {
	BookID   uint64 `json:"book_id"`
	OrderID  uint64 `json:"order_id"`
	Quantity int    `json:"quantity"`
}

type CreateBookOrderDTO struct {
	Quantity int `json:"quantity"`
}

func (o *BookOrderDTO) ToModel() *dbmodels.BookOrder {
	return &dbmodels.BookOrder{
		BookID:   int64(o.BookID),
		OrderID:  int64(o.OrderID),
		Quantity: o.Quantity,
	}
}

func (o *CreateBookOrderDTO) ToModel() *dbmodels.BookOrder {
	return &dbmodels.BookOrder{
		Quantity: o.Quantity,
	}
}

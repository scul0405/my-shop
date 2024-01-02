package dto

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"time"
)

type OrderDTO struct {
	ID        uint64            `json:"id"`
	Total     int               `json:"total"`
	Status    bool              `json:"status"`
	CreatedAt time.Time         `json:"created_at"`
	Books     []*BookInOrderDTO `json:"books,omitempty"`
}

type BooksInCreateOrder struct {
	ID       int64 `json:"id"`
	Quantity int   `json:"quantity"`
}

type CreateOrderDTO struct {
	Books []*BooksInCreateOrder `json:"books"`
}

type UpdateOrderDTO struct {
	ID    uint64                `json:"id"`
	Books []*BooksInCreateOrder `json:"books"`
}

func (o *OrderDTO) ToModel() *dbmodels.Order {
	return &dbmodels.Order{
		ID:        int64(o.ID),
		Total:     o.Total,
		Status:    o.Status,
		CreatedAt: o.CreatedAt,
	}
}

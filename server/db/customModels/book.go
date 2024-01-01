package customdbmodels

import dbmodels "github.com/scul0405/my-shop/server/db/models"

type BookInOrder struct {
	dbmodels.Book `boil:",bind"`
	OrderQuantity int `boil:"order_quantity"`
}

type BookInOrderSlice []*BookInOrder

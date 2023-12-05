package dbconverter

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
)

func OrderModelToDto(orderModel *dbmodels.Order) *dto.OrderDTO {
	return &dto.OrderDTO{
		ID:        uint64(orderModel.ID),
		Total:     orderModel.Total,
		Status:    orderModel.Status,
		CreatedAt: orderModel.CreatedAt,
	}
}

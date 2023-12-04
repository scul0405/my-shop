package usecase

import (
	"context"
	"github.com/scul0405/my-shop/server/config"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/internal/order"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"time"
)

type orderUseCase struct {
	cfg       *config.Config
	orderRepo order.Repository
	logger    logger.Logger
}

func NewOrderUseCase(
	cfg *config.Config,
	orderRepo order.Repository,
	logger logger.Logger) order.UseCase {
	return &orderUseCase{cfg: cfg, orderRepo: orderRepo, logger: logger}
}

func (u *orderUseCase) Create(ctx context.Context, order *dto.OrderDTO) (*dto.OrderDTO, error) {
	// set created at to null because it will be set by db
	order.CreatedAt = time.Time{}
	createdOrder, err := u.orderRepo.Create(ctx, order.ToModel())
	if err != nil {
		return nil, err
	}

	return orderModelToDto(createdOrder), nil
}

func (u *orderUseCase) GetByID(ctx context.Context, id uint64) (*dto.OrderDTO, error) {
	orderModel, err := u.orderRepo.GetByID(ctx, id)
	if err != nil {
		return nil, err
	}

	return orderModelToDto(orderModel), nil
}

func (u *orderUseCase) Update(ctx context.Context, order *dto.OrderDTO) error {
	whiteList := []string{"status"}
	err := u.orderRepo.Update(ctx, order.ToModel(), whiteList...)
	if err != nil {
		return err
	}

	return nil
}

func (u *orderUseCase) Delete(ctx context.Context, id uint64) error {
	err := u.orderRepo.Delete(ctx, id)
	if err != nil {
		return err
	}

	return nil
}

func (u *orderUseCase) List(ctx context.Context, pq *utils.PaginationQuery) (*utils.PaginationList, error) {
	var (
		paginationList *utils.PaginationList
		err            error
		ordersDTO      []*dto.OrderDTO
	)

	paginationList, err = u.orderRepo.List(ctx, pq)

	if err != nil {
		return nil, err
	}

	for _, orderModel := range paginationList.List.(dbmodels.OrderSlice) {
		ordersDTO = append(ordersDTO, orderModelToDto(orderModel))
	}

	paginationList.List = ordersDTO

	return paginationList, nil
}

func orderModelToDto(orderModel *dbmodels.Order) *dto.OrderDTO {
	return &dto.OrderDTO{
		ID:        uint64(orderModel.ID),
		Total:     orderModel.Total,
		Status:    orderModel.Status,
		CreatedAt: orderModel.CreatedAt,
	}
}

package usecase

import (
	"context"
	"github.com/scul0405/my-shop/server/config"
	dbconverter "github.com/scul0405/my-shop/server/db/converter"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/book"
	bookorder "github.com/scul0405/my-shop/server/internal/book_order"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/internal/order"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"github.com/volatiletech/sqlboiler/v4/queries/qm"
	"time"
)

type orderUseCase struct {
	cfg           *config.Config
	bookRepo      book.Repository
	bookOrderRepo bookorder.Repository
	orderRepo     order.Repository
	logger        logger.Logger
}

func NewOrderUseCase(
	cfg *config.Config,
	bookRepo book.Repository,
	bookOrderRepo bookorder.Repository,
	orderRepo order.Repository,
	logger logger.Logger) order.UseCase {
	return &orderUseCase{cfg: cfg, bookRepo: bookRepo, bookOrderRepo: bookOrderRepo, orderRepo: orderRepo, logger: logger}
}

func (u *orderUseCase) Create(ctx context.Context, order *dto.CreateOrderDTO) (*dto.OrderDTO, error) {

	// Create order
	orderModel := &dbmodels.Order{
		Total:  0,
		Status: true,
	}

	orderModel, err := u.orderRepo.Create(ctx, orderModel)
	if err != nil {
		return nil, err
	}

	// Add each book to order
	for _, book := range order.Books {
		data := &dto.CreateBookOrderDTO{
			Quantity: book.Quantity,
		}
		err = u.AddBook(ctx, uint64(orderModel.ID), uint64(book.ID), data)
		if err != nil {
			return nil, err
		}
	}

	// return final order
	return u.GetByID(ctx, uint64(orderModel.ID))
}

func (u *orderUseCase) AddBook(ctx context.Context, oid, bid uint64, data *dto.CreateBookOrderDTO) error {
	// check if book is exist
	bookModel, err := u.bookRepo.GetByID(ctx, bid)
	if err != nil {
		return err
	}

	// check if order is exist
	orderModel, err := u.GetByID(ctx, oid)
	if err != nil {
		return err
	}

	bookOrder := &dbmodels.BookOrder{
		BookID:   int64(bid),
		OrderID:  int64(oid),
		Quantity: data.Quantity,
	}

	// Add book to order
	err = u.orderRepo.AddBook(ctx, bookOrder)
	if err != nil {
		return err
	}

	// Update book
	bookModel.TotalSold += data.Quantity
	bookModel.Quantity -= data.Quantity

	err = u.bookRepo.Update(ctx, bookModel, "total_sold", "quantity")
	if err != nil {
		return err
	}

	// Update total of order
	orderModel.Total += bookModel.Price * data.Quantity
	err = u.orderRepo.Update(ctx, orderModel.ToModel(), "total")
	if err != nil {
		return err
	}

	return nil
}

func (u *orderUseCase) GetByID(ctx context.Context, id uint64) (*dto.OrderDTO, error) {
	orderModel, err := u.orderRepo.GetByID(ctx, id)
	if err != nil {
		return nil, err
	}

	bookModelSlice, err := u.bookRepo.GetByOrderID(ctx, id)
	if err != nil {
		return nil, err
	}

	orderDTO := dbconverter.OrderModelToDto(orderModel)

	for _, bookModel := range bookModelSlice {
		orderDTO.Books = append(orderDTO.Books, dbconverter.BookInOrderModelToDto(bookModel))
	}

	return orderDTO, nil
}

func (u *orderUseCase) Update(ctx context.Context, order *dto.UpdateOrderDTO) error {
	orderModel, err := u.orderRepo.GetByID(ctx, order.ID)
	if err != nil {
		return err
	}

	bookOrders, err := u.bookOrderRepo.GetByOrderID(ctx, order.ID)
	if err != nil {
		return err
	}
	flags := make([]bool, len(bookOrders))

	// update quantity and total sold for each book
	for _, book := range order.Books {
		// get book order
		bookOrderModel, err := u.bookOrderRepo.Get(ctx, uint64(book.ID), order.ID)
		if err != nil {
			return err
		}

		bookModel, err := u.bookRepo.GetByID(ctx, uint64(book.ID))
		if err != nil {
			return err
		}

		if book.Quantity > bookOrderModel.Quantity {
			bookModel.Quantity -= book.Quantity - bookOrderModel.Quantity
			bookModel.TotalSold += book.Quantity - bookOrderModel.Quantity
			orderModel.Total += bookModel.Price * (book.Quantity - bookOrderModel.Quantity)
		} else {
			bookModel.Quantity += bookOrderModel.Quantity - book.Quantity
			bookModel.TotalSold -= bookOrderModel.Quantity - book.Quantity
			orderModel.Total -= bookModel.Price * (bookOrderModel.Quantity - book.Quantity)
		}

		// update book
		err = u.bookRepo.Update(ctx, bookModel, "quantity", "total_sold")
		if err != nil {
			return err
		}

		// update book order
		bookOrderModel.Quantity = book.Quantity
		err = u.bookOrderRepo.Update(ctx, bookOrderModel)
		if err != nil {
			return err
		}

		for i, _ := range bookOrders {
			if bookOrders[i].BookID == book.ID {
				flags[i] = true
			}
		}
	}

	// delete book order not in update list
	for i, flag := range flags {
		if !flag {
			bookModel, err := u.bookRepo.GetByID(ctx, uint64(bookOrders[i].BookID))
			if err != nil {
				return err
			}

			bookModel.Quantity += bookOrders[i].Quantity
			bookModel.TotalSold -= bookOrders[i].Quantity
			orderModel.Total -= bookModel.Price * bookOrders[i].Quantity

			err = u.bookRepo.Update(ctx, bookModel, "quantity", "total_sold")
			if err != nil {
				return err
			}

			err = u.bookOrderRepo.Delete(ctx, uint64(bookOrders[i].BookID), order.ID)
			if err != nil {
				return err
			}
		}
	}

	// update order
	err = u.orderRepo.Update(ctx, orderModel, "total")

	return nil
}

func (u *orderUseCase) Delete(ctx context.Context, id uint64) error {
	// get book order

	// update quantity and total sold for each book
	bookModelSlice, err := u.bookRepo.GetByOrderIDDefault(ctx, id)
	if err != nil {
		return err
	}

	for _, bookModel := range bookModelSlice {
		// get book order
		bookOrderModel, err := u.bookOrderRepo.Get(ctx, uint64(bookModel.ID), id)
		if err != nil {
			return err
		}

		bookModel.Quantity += bookOrderModel.Quantity
		bookModel.TotalSold -= bookOrderModel.Quantity
		err = u.bookRepo.Update(ctx, bookModel, "quantity", "total_sold")
		if err != nil {
			return err
		}
	}

	// delete book order
	err = u.bookOrderRepo.DeleteByOrderID(ctx, id)
	if err != nil {
		return err
	}

	// delete order
	err = u.orderRepo.Delete(ctx, id)
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
		qms            = make([]qm.QueryMod, 0)
	)

	from := utils.ConvertTimeUTC(ctx.Value("from").(string))
	to := utils.ConvertTimeUTC(ctx.Value("to").(string))

	// check if from and to is not default parse value
	if from != (time.Time{}) {
		qms = append(qms, dbmodels.OrderWhere.CreatedAt.GTE(from))
	}
	if to != (time.Time{}) {
		to = to.AddDate(0, 0, 1)
		qms = append(qms, dbmodels.OrderWhere.CreatedAt.LT(to))
	}

	paginationList, err = u.orderRepo.List(ctx, pq, qms...)

	if err != nil {
		return nil, err
	}

	for _, orderModel := range paginationList.List.(dbmodels.OrderSlice) {
		ordersDTO = append(ordersDTO, dbconverter.OrderModelToDto(orderModel))
	}

	paginationList.List = ordersDTO

	return paginationList, nil
}

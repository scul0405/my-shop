package delivery

import (
	"encoding/json"
	"github.com/go-chi/chi/v5"
	"github.com/scul0405/my-shop/server/config"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/internal/order"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"net/http"
	"strconv"
)

type orderHandlers struct {
	cfg     *config.Config
	orderUC order.UseCase
	logger  logger.Logger
}

func NewOrderHandlers(cfg *config.Config, orderUC order.UseCase, logger logger.Logger) order.Handlers {
	return &orderHandlers{cfg: cfg, orderUC: orderUC, logger: logger}
}

// GetByID godoc
// @Summary Get an order by id
// @Description Get an order by id, returns order
// @Tags Order
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Success 200 {object} dto.OrderDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /orders/{id} [get]
func (h *orderHandlers) GetByID() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		orderDTO, err := h.orderUC.GetByID(r.Context(), uint64(id))
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, orderDTO)
	}
}

// Create godoc
// @Summary Create order
// @Description create an order, returns order
// @Tags Order
// @Accept json
// @Produce json
// @Param request body dto.OrderDTO true "input data"
// @Success 201 {object} dto.OrderDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /orders [post]
func (h *orderHandlers) Create() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.OrderDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		orderDTO, err := h.orderUC.Create(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusCreated, orderDTO)
	}
}

// Update godoc
// @Summary Update order by id
// @Description update an order by id, returns order
// @Tags Order
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Param request body dto.OrderDTO true "input data"
// @Success 200 {object} dto.OrderDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /orders/{id} [patch]
func (h *orderHandlers) Update() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		data := &dto.OrderDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		data.ID = uint64(id)
		err = h.orderUC.Update(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, data)
	}
}

// Delete godoc
// @Summary Delete order by id
// @Description Delete order by id
// @Tags Order
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Success 200 {string} string "success"
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /orders/{id} [delete]
func (h *orderHandlers) Delete() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		err := h.orderUC.Delete(r.Context(), uint64(id))
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, "success")
	}
}

// List godoc
// @Summary List orders
// @Description List orders, return list of orders
// @Tags Order
// @Accept json
// @Produce json
// @Param page query int false "page"
// @Param size query int false "size"
// @Success 200 {object} utils.PaginationList
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /orders [get]
func (h *orderHandlers) List() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		pq, err := utils.GetPaginationFromRequest(r)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		list, err := h.orderUC.List(r.Context(), pq)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, list)
	}
}

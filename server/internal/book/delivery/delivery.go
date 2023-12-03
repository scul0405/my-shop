package delivery

import (
	"encoding/json"
	"github.com/go-chi/chi/v5"
	"github.com/scul0405/my-shop/server/config"
	"github.com/scul0405/my-shop/server/internal/book"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"net/http"
	"strconv"
)

type bookHandlers struct {
	cfg    *config.Config
	bookUC book.UseCase
	logger logger.Logger
}

func NewBookHandlers(cfg *config.Config, bookUC book.UseCase, logger logger.Logger) book.Handlers {
	return &bookHandlers{cfg: cfg, bookUC: bookUC, logger: logger}
}

// GetByID godoc
// @Summary Get a book by id
// @Description Get a book by id, returns book
// @Tags Book
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Success 200 {object} dto.BookDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /books/{id} [get]
func (h *bookHandlers) GetByID() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		bookDTO, err := h.bookUC.GetByID(r.Context(), uint64(id))
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, bookDTO)
	}
}

// Create godoc
// @Summary Create book
// @Description create book, returns book
// @Tags Book
// @Accept json
// @Produce json
// @Param request body dto.BookDTO true "input data"
// @Success 201 {object} dto.BookDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /books [post]
func (h *bookHandlers) Create() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.BookDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		bookDTO, err := h.bookUC.Create(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, bookDTO)
	}
}

// Update godoc
// @Summary Update book by id
// @Description update book by id, returns book
// @Tags Book
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Param request body dto.BookDTO true "input data"
// @Success 200 {object} dto.BookDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /books/{id} [patch]
func (h *bookHandlers) Update() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		data := &dto.BookDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		data.ID = uint64(id)
		err = h.bookUC.Update(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, data)
	}
}

// Delete godoc
// @Summary Delete book by id
// @Description Delete book by id
// @Tags Book
// @Accept json
// @Produce json
// @Param id path string true "id"
// @Success 200 {string} string "success"
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /books/{id} [delete]
func (h *bookHandlers) Delete() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		id, _ := strconv.Atoi(chi.URLParam(r, "id"))

		err := h.bookUC.Delete(r.Context(), uint64(id))
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, "success")
	}
}

// List godoc
// @Summary List books
// @Description List books, return list of books
// @Tags Book
// @Accept json
// @Produce json
// @Param page query int false "page"
// @Param size query int false "size"
// @Success 200 {object} utils.PaginationList
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /books [get]
func (h *bookHandlers) List() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		pq, err := utils.GetPaginationFromRequest(r)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		list, err := h.bookUC.List(r.Context(), pq)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, list)
	}
}

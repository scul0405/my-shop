package delivery

import (
	"encoding/json"
	"github.com/scul0405/my-shop/server/config"
	bookcategory "github.com/scul0405/my-shop/server/internal/book_category"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"net/http"
)

type bookCategoryHandlers struct {
	cfg    *config.Config
	bcUC   bookcategory.UseCase
	logger logger.Logger
}

func NewBookCategoryHandlers(cfg *config.Config, bcUC bookcategory.UseCase, logger logger.Logger) bookcategory.Handlers {
	return &bookCategoryHandlers{cfg: cfg, bcUC: bcUC, logger: logger}
}

// Create godoc
// @Summary Create book category
// @Description create book category, returns book category
// @Tags Book Category
// @Accept json
// @Produce json
// @Param request body dto.BookCategoryDTO true "input data"
// @Success 201 {object} dto.BookCategoryDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /book_categories [post]
func (h *bookCategoryHandlers) Create() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.BookCategoryDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		bcDTO, err := h.bcUC.Create(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusCreated, bcDTO)
	}
}

// List godoc
// @Summary List book categories
// @Description List book categories, return list of book categories
// @Tags Book Category
// @Accept json
// @Produce json
// @Param page query int false "page"
// @Param size query int false "size"
// @Success 200 {object} utils.PaginationList
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /book_categories [get]
func (h *bookCategoryHandlers) List() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		pq, err := utils.GetPaginationFromRequest(r)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		list, err := h.bcUC.List(r.Context(), pq)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, list)
	}
}

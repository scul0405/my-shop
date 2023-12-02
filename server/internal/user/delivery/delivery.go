package delivery

import (
	"encoding/json"
	"github.com/scul0405/my-shop/server/config"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/internal/user"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"net/http"
)

type userHandlers struct {
	cfg    *config.Config
	userUC user.UseCase
	logger logger.Logger
}

func NewUserHandlers(cfg *config.Config, userUC user.UseCase, logger logger.Logger) user.Handlers {
	return &userHandlers{cfg: cfg, userUC: userUC, logger: logger}
}

func (h *userHandlers) Register() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.UserDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, http.StatusBadRequest, err.Error())
			return
		}

		userDTO, err := h.userUC.Register(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, http.StatusBadRequest, err.Error())
			return
		}

		utils.RespondWithJSON(w, http.StatusCreated, userDTO)
	}
}

func (h *userHandlers) Login() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.UserDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, http.StatusBadRequest, err.Error())
			return
		}

		userDTO, err := h.userUC.Login(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, http.StatusBadRequest, err.Error())
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, userDTO)
	}
}

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

// Register godoc
// @Summary Register new user
// @Description register new user, returns username
// @Tags User
// @Accept json
// @Produce json
// @Param request body dto.UserDTO true "input data"
// @Success 201 {object} dto.UserDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /users/register [post]
func (h *userHandlers) Register() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.UserDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		userDTO, err := h.userUC.Register(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusCreated, userDTO)
	}
}

// Login godoc
// @Summary Login user
// @Description login user, returns username
// @Tags User
// @Accept json
// @Produce json
// @Param request body dto.UserDTO true "input data"
// @Success 200 {object} dto.UserDTO
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /users/login [post]
func (h *userHandlers) Login() http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &dto.UserDTO{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		userDTO, err := h.userUC.Login(r.Context(), data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, userDTO)
	}
}

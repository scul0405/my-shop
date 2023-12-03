package usecase

import (
	"context"
	"github.com/pkg/errors"
	"github.com/scul0405/my-shop/server/config"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
	"github.com/scul0405/my-shop/server/internal/user"
	httpErrors "github.com/scul0405/my-shop/server/pkg/http_errors"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"golang.org/x/crypto/bcrypt"
	"strings"
)

type userUseCase struct {
	cfg      *config.Config
	userRepo user.Repository
	logger   logger.Logger
}

func NewUserUseCase(
	cfg *config.Config,
	userRepo user.Repository,
	logger logger.Logger) user.UseCase {
	return &userUseCase{cfg: cfg, userRepo: userRepo, logger: logger}
}

func (u *userUseCase) Register(ctx context.Context, user *dto.UserDTO) (*dto.UserDTO, error) {
	userModel := user.ToModel()

	err := prepareCreate(userModel)
	if err != nil {
		return nil, err
	}

	userModel, err = u.userRepo.Register(ctx, userModel)
	if err != nil {
		return nil, err
	}

	userResp := userModelToDto(userModel)
	userResp.ToResponse()

	return userResp, nil
}

func (u *userUseCase) Login(ctx context.Context, user *dto.UserDTO) (*dto.UserDTO, error) {
	userModel := user.ToModel()

	userModel, err := u.userRepo.GetByUsername(ctx, user.Username)
	if err != nil {
		return nil, err
	}

	// compare password
	if err = comparePassword(userModel, user.Password); err != nil {
		return nil, httpErrors.NewBadRequestError(errors.Wrap(err, "wrong password"))
	}

	userResp := userModelToDto(userModel)
	userResp.ToResponse()

	return userResp, nil
}

func userModelToDto(user *dbmodels.User) *dto.UserDTO {
	return &dto.UserDTO{
		Username: user.Username,
		Password: user.Password,
	}
}

// prepareCreate prepare for register
func prepareCreate(u *dbmodels.User) error {
	u.Password = strings.TrimSpace(u.Password)
	if err := hashPassword(u); err != nil {
		return err
	}

	return nil
}

// hashPassword hash the password with bcrypt
func hashPassword(u *dbmodels.User) error {
	hashedPassword, err := bcrypt.GenerateFromPassword([]byte(u.Password), bcrypt.DefaultCost)
	if err != nil {
		return err
	}

	u.Password = string(hashedPassword)
	return nil
}

// comparePassword compare user password and payload
func comparePassword(u *dbmodels.User, password string) error {
	if err := bcrypt.CompareHashAndPassword([]byte(u.Password), []byte(password)); err != nil {
		return err
	}

	return nil
}

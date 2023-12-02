package user

import (
	"context"
	"github.com/scul0405/my-shop/server/internal/dto"
)

type UseCase interface {
	Register(ctx context.Context, user *dto.UserDTO) (*dto.UserDTO, error)
	Login(ctx context.Context, user *dto.UserDTO) (*dto.UserDTO, error)
}

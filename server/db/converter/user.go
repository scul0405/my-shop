package dbconverter

import (
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/dto"
)

func UserModelToDto(user *dbmodels.User) *dto.UserDTO {
	return &dto.UserDTO{
		Username: user.Username,
		Password: user.Password,
	}
}

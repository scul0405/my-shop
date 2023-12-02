package dto

import dbmodels "github.com/scul0405/my-shop/server/db/models"

type UserDTO struct {
	Username string `json:"username,omitempty"`
	Password string `json:"password,omitempty"`
}

func (u *UserDTO) ToModel() *dbmodels.User {
	return &dbmodels.User{
		Username: u.Username,
		Password: u.Password,
	}
}

// ToResponse sanitize password before response
func (u *UserDTO) ToResponse() {
	u.Password = ""
}

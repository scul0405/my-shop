package user

import (
	"context"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
)

type Repository interface {
	Register(ctx context.Context, user *dbmodels.User) (*dbmodels.User, error)
	GetByUsername(ctx context.Context, username string) (*dbmodels.User, error)
}

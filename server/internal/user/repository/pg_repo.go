package repository

import (
	"context"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/internal/user"
	"github.com/volatiletech/sqlboiler/v4/boil"
)

type userRepo struct {
	db *sqlx.DB
}

func NewUserRepo(db *sqlx.DB) user.Repository {
	return &userRepo{
		db: db,
	}
}

func (r *userRepo) Register(ctx context.Context, user *dbmodels.User) (*dbmodels.User, error) {
	err := user.Insert(ctx, r.db, boil.Infer())
	if err != nil {
		return nil, err
	}

	return user, nil
}

func (r *userRepo) GetByUsername(ctx context.Context, username string) (*dbmodels.User, error) {
	userModel, err := dbmodels.Users(dbmodels.UserWhere.Username.EQ(username)).One(ctx, r.db)
	if err != nil {
		return nil, err
	}

	return userModel, nil
}

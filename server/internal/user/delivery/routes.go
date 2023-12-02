package delivery

import (
	"github.com/go-chi/chi/v5"
	"github.com/scul0405/my-shop/server/internal/user"
)

func MapUserRoutes(userGroup *chi.Mux, pattern string, h user.Handlers) {
	userGroup.Route(pattern, func(r chi.Router) {
		r.Post("/register", h.Register())
		r.Post("/login", h.Login())
	})
}

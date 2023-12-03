package delivery

import (
	"github.com/go-chi/chi/v5"
	"github.com/scul0405/my-shop/server/internal/book"
)

func MapBookRoutes(userGroup *chi.Mux, pattern string, h book.Handlers) {
	userGroup.Route(pattern, func(r chi.Router) {
		r.Get("/{id:^[0-9]*$}", h.GetByID())
		r.Post("/", h.Create())
		r.Patch("/{id:^[0-9]*$}", h.Update())
		r.Delete("/{id:^[0-9]*$}", h.Delete())
		r.Get("/", h.List())
	})
}

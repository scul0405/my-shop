package delivery

import (
	"github.com/go-chi/chi/v5"
	"github.com/scul0405/my-shop/server/internal/order"
)

func MapOrderRoutes(userGroup *chi.Mux, pattern string, h order.Handlers) {
	userGroup.Route(pattern, func(r chi.Router) {
		r.Get("/{id:^[0-9]*$}", h.GetByID())
		r.Post("/", h.Create())
		r.Post("/{id:^[0-9]*$}/books/{bid:^[0-9]*$}", h.AddBook())
		r.Patch("/{id:^[0-9]*$}", h.Update())
		r.Delete("/{id:^[0-9]*$}", h.Delete())
		r.Get("/", h.List())
	})
}

package delivery

import (
	"github.com/go-chi/chi/v5"
	bookcategory "github.com/scul0405/my-shop/server/internal/book_category"
)

func MapBookCategoryRoutes(userGroup *chi.Mux, pattern string, h bookcategory.Handlers) {
	userGroup.Route(pattern, func(r chi.Router) {
		r.Post("/", h.Create())
		r.Patch("/{id}", h.Update())
		r.Delete("/{id}", h.Delete())
		r.Get("/", h.List())
	})
}

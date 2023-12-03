package server

import (
	"github.com/go-chi/chi/v5"
	"github.com/go-chi/chi/v5/middleware"
	"github.com/go-chi/cors"
	bookDelivery "github.com/scul0405/my-shop/server/internal/book/delivery"
	bookRepository "github.com/scul0405/my-shop/server/internal/book/repository"
	bookUseCase "github.com/scul0405/my-shop/server/internal/book/usecase"
	userDelivery "github.com/scul0405/my-shop/server/internal/user/delivery"
	userRepository "github.com/scul0405/my-shop/server/internal/user/repository"
	userUseCase "github.com/scul0405/my-shop/server/internal/user/usecase"
	httpSwagger "github.com/swaggo/http-swagger"
	"net/http"
)

func (s *Server) MapHandlers() error {
	// init + DI
	userRepo := userRepository.NewUserRepo(s.db)
	userUC := userUseCase.NewUserUseCase(s.cfg, userRepo, s.logger)
	userHandler := userDelivery.NewUserHandlers(s.cfg, userUC, s.logger)

	bookRepo := bookRepository.NewBookRepo(s.db)
	bookUC := bookUseCase.NewBookUseCase(s.cfg, bookRepo, s.logger)
	bookHandler := bookDelivery.NewBookHandlers(s.cfg, bookUC, s.logger)

	// Chi middlewares
	s.chi.Use(middleware.Logger)
	s.chi.Use(middleware.Recoverer)
	s.chi.Use(cors.Handler(cors.Options{
		AllowedOrigins:   []string{"https://*", "http://*"},
		AllowedMethods:   []string{"GET", "POST", "PATCH", "DELETE", "OPTIONS"},
		AllowedHeaders:   []string{"Accept", "Authorization", "Content-Type", "X-CSRF-Token"},
		ExposedHeaders:   []string{"Link"},
		AllowCredentials: false,
		MaxAge:           300, // Maximum value not ignored by any of major browsers
	}))

	// Swagger
	s.chi.Route("/swagger", func(r chi.Router) {
		r.Get("/*", httpSwagger.WrapHandler)
	})

	// group routes
	v1 := chi.NewRouter()
	s.chi.Mount("/api/v1", v1)

	v1.Route("/health", func(r chi.Router) {
		r.Get("/", func(w http.ResponseWriter, r *http.Request) {
			w.Write([]byte("Health Check"))
		})
	})

	userDelivery.MapUserRoutes(v1, "/users", userHandler)
	bookDelivery.MapBookRoutes(v1, "/books", bookHandler)

	return nil
}

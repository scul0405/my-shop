package server

import (
	"github.com/go-chi/chi/v5"
)

func (s *Server) MapHandlers() error {

	v1 := chi.NewRouter()
	s.chi.Mount("/api/v1", v1)

	v1.Route("/health", func(r chi.Router) {
	})

	return nil
}

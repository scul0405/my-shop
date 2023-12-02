package server

import (
	"context"
	"github.com/go-chi/chi/v5"
	"github.com/jmoiron/sqlx"
	"github.com/scul0405/my-shop/server/config"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"log"
	"net/http"
	"os"
	"os/signal"
	"syscall"
	"time"
)

const (
	ctxTimeout     = 30
	maxHeaderBytes = 1 << 20
)

type Server struct {
	chi    *chi.Mux
	cfg    *config.Config
	db     *sqlx.DB
	logger logger.Logger
}

func NewServer(
	cfg *config.Config,
	db *sqlx.DB,
	logger logger.Logger,
) *Server {
	return &Server{
		chi:    chi.NewRouter(),
		cfg:    cfg,
		db:     db,
		logger: logger,
	}
}

func (s *Server) Run() error {

	server := &http.Server{
		Addr:           s.cfg.Server.Port,
		ReadTimeout:    time.Second * s.cfg.Server.ReadTimeout,
		WriteTimeout:   time.Second * s.cfg.Server.WriteTimeout,
		MaxHeaderBytes: maxHeaderBytes,
		Handler:        s.chi,
	}

	// Server run context
	serverCtx, serverStopCtx := context.WithCancel(context.Background())

	quit := make(chan os.Signal, 1)
	signal.Notify(quit, os.Interrupt, syscall.SIGHUP, syscall.SIGINT, syscall.SIGTERM, syscall.SIGQUIT)
	go func() {
		<-quit

		// Shutdown signal with grace period of 30 seconds
		shutdownCtx, _ := context.WithTimeout(serverCtx, ctxTimeout*time.Second)

		go func() {
			<-shutdownCtx.Done()
			if shutdownCtx.Err() == context.DeadlineExceeded {
				log.Fatal("graceful shutdown timed out.. forcing exit.")
			}
		}()

		// Trigger graceful shutdown
		err := server.Shutdown(shutdownCtx)
		if err != nil {
			log.Fatal(err)
		}
		serverStopCtx()
	}()

	if err := s.MapHandlers(); err != nil {
		return err
	}

	// Run the server
	s.logger.Infof("Server is listening on PORT: %s", s.cfg.Server.Port)
	err := server.ListenAndServe()
	if err != nil && err != http.ErrServerClosed {
		return err
	}

	// Wait for server context to be stopped
	<-serverCtx.Done()
	s.logger.Info("Server Exited Properly")

	return nil
}

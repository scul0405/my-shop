package main

import (
	"github.com/scul0405/my-shop/server/config"
	"github.com/scul0405/my-shop/server/internal/server"
	"github.com/scul0405/my-shop/server/pkg/db"
	"github.com/scul0405/my-shop/server/pkg/logger"
	"log"
)

func main() {
	log.Println("Starting api server")

	cfgFile, err := config.LoadConfig("./config/config")
	if err != nil {
		log.Fatalf("LoadConfig: %v", err)
	}

	cfg, err := config.ParseConfig(cfgFile)
	if err != nil {
		log.Fatalf("ParseConfig: %v", err)
	}

	appLogger := logger.NewApiLogger(cfg)
	appLogger.InitLogger()
	appLogger.Infof("AppVersion: %s, LogLevel: %s, Mode: %s", cfg.Server.AppVersion, cfg.Logger.Level, cfg.Server.Mode)

	// Database
	psqlDB, err := db.NewPsqlDB(cfg)
	if err != nil {
		appLogger.Fatalf("Postgresql init: %s", err)
	} else {
		appLogger.Infof("Postgres connected, Status: %#v", psqlDB.Stats())
	}
	defer psqlDB.Close()

	s := server.NewServer(cfg, psqlDB, appLogger)
	if err = s.Run(); err != nil {
		log.Fatal(err)
	}
}

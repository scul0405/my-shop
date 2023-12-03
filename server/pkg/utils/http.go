package utils

import (
	"encoding/json"
	"fmt"
	"github.com/scul0405/my-shop/server/pkg/http_errors"
	"net/http"
)

// RespondWithError return error message
func RespondWithError(w http.ResponseWriter, err error) {
	code, payload := httpErrors.ErrorResponse(err)
	RespondWithJSON(w, code, payload)
}

// RespondWithJSON write json response format
func RespondWithJSON(w http.ResponseWriter, code int, payload interface{}) {
	response, _ := json.Marshal(payload)
	fmt.Println(payload)
	w.Header().Set("Content-Type", "application/json")
	w.WriteHeader(code)
	w.Write(response)
}

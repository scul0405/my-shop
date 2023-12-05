package utils

import (
	"context"
	"net/http"
)

func setContextValue(r *http.Request, key string) context.Context {
	data := r.URL.Query().Get(key)

	return context.WithValue(r.Context(), key, data)
}

func SetContextValueFromRequest(r *http.Request, params ...string) *http.Request {
	for _, param := range params {
		r = r.WithContext(setContextValue(r, param))
	}

	return r
}

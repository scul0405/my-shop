package order

import "net/http"

type Handlers interface {
	Create() http.HandlerFunc
	AddBook() http.HandlerFunc
	GetByID() http.HandlerFunc
	Update() http.HandlerFunc
	Delete() http.HandlerFunc
	List() http.HandlerFunc
}

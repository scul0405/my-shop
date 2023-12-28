package bookcategory

import "net/http"

type Handlers interface {
	Create() http.HandlerFunc
	Update() http.HandlerFunc
	Delete() http.HandlerFunc
	List() http.HandlerFunc
}

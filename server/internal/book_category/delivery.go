package bookcategory

import "net/http"

type Handlers interface {
	Create() http.HandlerFunc
	List() http.HandlerFunc
}

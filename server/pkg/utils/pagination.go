package utils

import (
	"fmt"
	"math"
	"net/http"
	"strconv"
)

const (
	defaultPage = 1
	defaultSize = 10
)

// PaginationQuery query params
type PaginationQuery struct {
	Size    int    `json:"size,omitempty"`
	Page    int    `json:"page,omitempty"`
	OrderBy string `json:"orderBy,omitempty"`
}

type PaginationList struct {
	TotalCount int         `json:"total_count"`
	TotalPages int         `json:"total_pages"`
	Page       int         `json:"page"`
	Size       int         `json:"size"`
	HasMore    bool        `json:"has_more"`
	List       interface{} `json:"list"`
}

func (q *PaginationQuery) SetSize(sizeQuery string) error {
	if sizeQuery == "" {
		q.Size = defaultSize
		return nil
	}
	n, err := strconv.Atoi(sizeQuery)
	if err != nil {
		return err
	}
	q.Size = n

	return nil
}

func (q *PaginationQuery) SetPage(pageQuery string) error {
	if pageQuery == "" {
		q.Page = defaultPage
		return nil
	}
	n, err := strconv.Atoi(pageQuery)
	if err != nil {
		return err
	}
	q.Page = n

	return nil
}

func (q *PaginationQuery) SetOrderBy(orderByQuery string) {
	q.OrderBy = orderByQuery
}

func (q *PaginationQuery) GetOffset() int {
	if q.Page == 0 {
		return 0
	}
	return (q.Page - 1) * q.Size
}

func (q *PaginationQuery) GetLimit() int {
	return q.Size
}

func (q *PaginationQuery) GetOrderBy() string {
	return q.OrderBy
}

func (q *PaginationQuery) GetPage() int {
	return q.Page
}

func (q *PaginationQuery) GetSize() int {
	return q.Size
}

func (q *PaginationQuery) GetQueryString() string {
	return fmt.Sprintf("page=%v&size=%v&orderBy=%s", q.GetPage(), q.GetSize(), q.GetOrderBy())
}

// GetPaginationFromRequest get pagination query struct from Request
func GetPaginationFromRequest(r *http.Request) (*PaginationQuery, error) {
	q := &PaginationQuery{}
	if err := q.SetPage(r.URL.Query().Get("page")); err != nil {
		return nil, err
	}
	if err := q.SetSize(r.URL.Query().Get("size")); err != nil {
		return nil, err
	}
	q.SetOrderBy(r.URL.Query().Get("orderBy"))

	return q, nil
}

func GetTotalPages(totalCount int, pageSize int) int {
	d := float64(totalCount) / float64(pageSize)
	return int(math.Ceil(d))
}

func GetHasMore(currentPage int, totalCount int, pageSize int) bool {
	return currentPage < totalCount/pageSize
}

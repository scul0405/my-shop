package importdata

import (
	"encoding/json"
	"fmt"
	_ "github.com/jackc/pgx/stdlib"
	"github.com/jmoiron/sqlx"
	dbmodels "github.com/scul0405/my-shop/server/db/models"
	"github.com/scul0405/my-shop/server/pkg/utils"
	"net/http"
)

type BookImport struct {
	Name      string `json:"name"`
	Author    string `json:"author"`
	Desc      string `json:"desc"`
	Price     int64  `json:"price"`
	TotalSold int64  `json:"total_sold"`
	Quantity  int64  `json:"quantity"`
}

type ImportData struct {
	Books          []BookImport `json:"books"`
	BookCategories []string     `json:"book_categories"`
	Categories     []string     `json:"categories"`
}

// DataHandler godoc
// @Summary Import Data
// @Description import data including books, book_categories, categories
// @Tags Import Data
// @Accept json
// @Produce json
// @Param request body ImportData true "input data"
// @Success 200 {string} string "success"
// @Failure 400 {object} httpErrors.RestError
// @Failure 500 {object} httpErrors.RestError
// @Router /import [post]
func DataHandler(db *sqlx.DB) http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		data := &ImportData{}
		err := json.NewDecoder(r.Body).Decode(data)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		// begin transaction
		tx, err := db.BeginTx(r.Context(), nil)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}
		defer tx.Rollback()

		// insert categories
		sqlStr := "INSERT INTO book_categories (name) VALUES "
		for _, category := range data.Categories {
			sqlStr += "('" + category + "'),"
		}

		// remove last comma
		sqlStr = sqlStr[:len(sqlStr)-1]

		// execute sql
		_, err = tx.Exec(sqlStr)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		// done insert categories
		err = tx.Commit()
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		// Get all categories to make a map
		categories, err := dbmodels.BookCategories().All(r.Context(), db)

		// make a map
		categoryMap := make(map[string]int64)
		for _, category := range categories {
			categoryMap[category.Name] = category.ID
		}

		// begin transaction
		tx, err = db.BeginTx(r.Context(), nil)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}
		defer tx.Rollback()

		// insert books
		sqlStr = "INSERT INTO books (category_id, name, author, \"desc\", price, total_sold, quantity) VALUES "
		for i, book := range data.Books {
			sqlStr += "(" + fmt.Sprintf("%d", categoryMap[data.BookCategories[i]]) + ",'" + book.Name + "','" + book.Author + "','" + book.Desc + "'," + fmt.Sprintf("%d", book.Price) + "," + fmt.Sprintf("%d", book.TotalSold) + "," + fmt.Sprintf("%d", book.Quantity) + "),"
		}

		// remove last comma
		sqlStr = sqlStr[:len(sqlStr)-1]

		// execute sql
		_, err = tx.Exec(sqlStr)
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		// done all
		err = tx.Commit()
		if err != nil {
			utils.RespondWithError(w, err)
			return
		}

		utils.RespondWithJSON(w, http.StatusOK, "success")
	}
}

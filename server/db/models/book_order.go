// Code generated by SQLBoiler 4.15.0 (https://github.com/volatiletech/sqlboiler). DO NOT EDIT.
// This file is meant to be re-generated in place and/or deleted at any time.

package dbmodels

import (
	"context"
	"database/sql"
	"fmt"
	"reflect"
	"strconv"
	"strings"
	"sync"
	"time"

	"github.com/friendsofgo/errors"
	"github.com/volatiletech/sqlboiler/v4/boil"
	"github.com/volatiletech/sqlboiler/v4/queries"
	"github.com/volatiletech/sqlboiler/v4/queries/qm"
	"github.com/volatiletech/sqlboiler/v4/queries/qmhelper"
	"github.com/volatiletech/strmangle"
)

// BookOrder is an object representing the database table.
type BookOrder struct {
	BookID   int64 `boil:"book_id" json:"book_id" toml:"book_id" yaml:"book_id"`
	OrderID  int64 `boil:"order_id" json:"order_id" toml:"order_id" yaml:"order_id"`
	Quantity int   `boil:"quantity" json:"quantity" toml:"quantity" yaml:"quantity"`

	R *bookOrderR `boil:"-" json:"-" toml:"-" yaml:"-"`
	L bookOrderL  `boil:"-" json:"-" toml:"-" yaml:"-"`
}

var BookOrderColumns = struct {
	BookID   string
	OrderID  string
	Quantity string
}{
	BookID:   "book_id",
	OrderID:  "order_id",
	Quantity: "quantity",
}

var BookOrderTableColumns = struct {
	BookID   string
	OrderID  string
	Quantity string
}{
	BookID:   "book_order.book_id",
	OrderID:  "book_order.order_id",
	Quantity: "book_order.quantity",
}

// Generated where

type whereHelperint struct{ field string }

func (w whereHelperint) EQ(x int) qm.QueryMod  { return qmhelper.Where(w.field, qmhelper.EQ, x) }
func (w whereHelperint) NEQ(x int) qm.QueryMod { return qmhelper.Where(w.field, qmhelper.NEQ, x) }
func (w whereHelperint) LT(x int) qm.QueryMod  { return qmhelper.Where(w.field, qmhelper.LT, x) }
func (w whereHelperint) LTE(x int) qm.QueryMod { return qmhelper.Where(w.field, qmhelper.LTE, x) }
func (w whereHelperint) GT(x int) qm.QueryMod  { return qmhelper.Where(w.field, qmhelper.GT, x) }
func (w whereHelperint) GTE(x int) qm.QueryMod { return qmhelper.Where(w.field, qmhelper.GTE, x) }
func (w whereHelperint) IN(slice []int) qm.QueryMod {
	values := make([]interface{}, 0, len(slice))
	for _, value := range slice {
		values = append(values, value)
	}
	return qm.WhereIn(fmt.Sprintf("%s IN ?", w.field), values...)
}
func (w whereHelperint) NIN(slice []int) qm.QueryMod {
	values := make([]interface{}, 0, len(slice))
	for _, value := range slice {
		values = append(values, value)
	}
	return qm.WhereNotIn(fmt.Sprintf("%s NOT IN ?", w.field), values...)
}

var BookOrderWhere = struct {
	BookID   whereHelperint64
	OrderID  whereHelperint64
	Quantity whereHelperint
}{
	BookID:   whereHelperint64{field: "\"book_order\".\"book_id\""},
	OrderID:  whereHelperint64{field: "\"book_order\".\"order_id\""},
	Quantity: whereHelperint{field: "\"book_order\".\"quantity\""},
}

// BookOrderRels is where relationship names are stored.
var BookOrderRels = struct {
	Book  string
	Order string
}{
	Book:  "Book",
	Order: "Order",
}

// bookOrderR is where relationships are stored.
type bookOrderR struct {
	Book  *Book  `boil:"Book" json:"Book" toml:"Book" yaml:"Book"`
	Order *Order `boil:"Order" json:"Order" toml:"Order" yaml:"Order"`
}

// NewStruct creates a new relationship struct
func (*bookOrderR) NewStruct() *bookOrderR {
	return &bookOrderR{}
}

func (r *bookOrderR) GetBook() *Book {
	if r == nil {
		return nil
	}
	return r.Book
}

func (r *bookOrderR) GetOrder() *Order {
	if r == nil {
		return nil
	}
	return r.Order
}

// bookOrderL is where Load methods for each relationship are stored.
type bookOrderL struct{}

var (
	bookOrderAllColumns            = []string{"book_id", "order_id", "quantity"}
	bookOrderColumnsWithoutDefault = []string{}
	bookOrderColumnsWithDefault    = []string{"book_id", "order_id", "quantity"}
	bookOrderPrimaryKeyColumns     = []string{"book_id", "order_id"}
	bookOrderGeneratedColumns      = []string{}
)

type (
	// BookOrderSlice is an alias for a slice of pointers to BookOrder.
	// This should almost always be used instead of []BookOrder.
	BookOrderSlice []*BookOrder
	// BookOrderHook is the signature for custom BookOrder hook methods
	BookOrderHook func(context.Context, boil.ContextExecutor, *BookOrder) error

	bookOrderQuery struct {
		*queries.Query
	}
)

// Cache for insert, update and upsert
var (
	bookOrderType                 = reflect.TypeOf(&BookOrder{})
	bookOrderMapping              = queries.MakeStructMapping(bookOrderType)
	bookOrderPrimaryKeyMapping, _ = queries.BindMapping(bookOrderType, bookOrderMapping, bookOrderPrimaryKeyColumns)
	bookOrderInsertCacheMut       sync.RWMutex
	bookOrderInsertCache          = make(map[string]insertCache)
	bookOrderUpdateCacheMut       sync.RWMutex
	bookOrderUpdateCache          = make(map[string]updateCache)
	bookOrderUpsertCacheMut       sync.RWMutex
	bookOrderUpsertCache          = make(map[string]insertCache)
)

var (
	// Force time package dependency for automated UpdatedAt/CreatedAt.
	_ = time.Second
	// Force qmhelper dependency for where clause generation (which doesn't
	// always happen)
	_ = qmhelper.Where
)

var bookOrderAfterSelectHooks []BookOrderHook

var bookOrderBeforeInsertHooks []BookOrderHook
var bookOrderAfterInsertHooks []BookOrderHook

var bookOrderBeforeUpdateHooks []BookOrderHook
var bookOrderAfterUpdateHooks []BookOrderHook

var bookOrderBeforeDeleteHooks []BookOrderHook
var bookOrderAfterDeleteHooks []BookOrderHook

var bookOrderBeforeUpsertHooks []BookOrderHook
var bookOrderAfterUpsertHooks []BookOrderHook

// doAfterSelectHooks executes all "after Select" hooks.
func (o *BookOrder) doAfterSelectHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderAfterSelectHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doBeforeInsertHooks executes all "before insert" hooks.
func (o *BookOrder) doBeforeInsertHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderBeforeInsertHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doAfterInsertHooks executes all "after Insert" hooks.
func (o *BookOrder) doAfterInsertHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderAfterInsertHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doBeforeUpdateHooks executes all "before Update" hooks.
func (o *BookOrder) doBeforeUpdateHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderBeforeUpdateHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doAfterUpdateHooks executes all "after Update" hooks.
func (o *BookOrder) doAfterUpdateHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderAfterUpdateHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doBeforeDeleteHooks executes all "before Delete" hooks.
func (o *BookOrder) doBeforeDeleteHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderBeforeDeleteHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doAfterDeleteHooks executes all "after Delete" hooks.
func (o *BookOrder) doAfterDeleteHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderAfterDeleteHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doBeforeUpsertHooks executes all "before Upsert" hooks.
func (o *BookOrder) doBeforeUpsertHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderBeforeUpsertHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// doAfterUpsertHooks executes all "after Upsert" hooks.
func (o *BookOrder) doAfterUpsertHooks(ctx context.Context, exec boil.ContextExecutor) (err error) {
	if boil.HooksAreSkipped(ctx) {
		return nil
	}

	for _, hook := range bookOrderAfterUpsertHooks {
		if err := hook(ctx, exec, o); err != nil {
			return err
		}
	}

	return nil
}

// AddBookOrderHook registers your hook function for all future operations.
func AddBookOrderHook(hookPoint boil.HookPoint, bookOrderHook BookOrderHook) {
	switch hookPoint {
	case boil.AfterSelectHook:
		bookOrderAfterSelectHooks = append(bookOrderAfterSelectHooks, bookOrderHook)
	case boil.BeforeInsertHook:
		bookOrderBeforeInsertHooks = append(bookOrderBeforeInsertHooks, bookOrderHook)
	case boil.AfterInsertHook:
		bookOrderAfterInsertHooks = append(bookOrderAfterInsertHooks, bookOrderHook)
	case boil.BeforeUpdateHook:
		bookOrderBeforeUpdateHooks = append(bookOrderBeforeUpdateHooks, bookOrderHook)
	case boil.AfterUpdateHook:
		bookOrderAfterUpdateHooks = append(bookOrderAfterUpdateHooks, bookOrderHook)
	case boil.BeforeDeleteHook:
		bookOrderBeforeDeleteHooks = append(bookOrderBeforeDeleteHooks, bookOrderHook)
	case boil.AfterDeleteHook:
		bookOrderAfterDeleteHooks = append(bookOrderAfterDeleteHooks, bookOrderHook)
	case boil.BeforeUpsertHook:
		bookOrderBeforeUpsertHooks = append(bookOrderBeforeUpsertHooks, bookOrderHook)
	case boil.AfterUpsertHook:
		bookOrderAfterUpsertHooks = append(bookOrderAfterUpsertHooks, bookOrderHook)
	}
}

// One returns a single bookOrder record from the query.
func (q bookOrderQuery) One(ctx context.Context, exec boil.ContextExecutor) (*BookOrder, error) {
	o := &BookOrder{}

	queries.SetLimit(q.Query, 1)

	err := q.Bind(ctx, exec, o)
	if err != nil {
		if errors.Is(err, sql.ErrNoRows) {
			return nil, sql.ErrNoRows
		}
		return nil, errors.Wrap(err, "dbmodels: failed to execute a one query for book_order")
	}

	if err := o.doAfterSelectHooks(ctx, exec); err != nil {
		return o, err
	}

	return o, nil
}

// All returns all BookOrder records from the query.
func (q bookOrderQuery) All(ctx context.Context, exec boil.ContextExecutor) (BookOrderSlice, error) {
	var o []*BookOrder

	err := q.Bind(ctx, exec, &o)
	if err != nil {
		return nil, errors.Wrap(err, "dbmodels: failed to assign all query results to BookOrder slice")
	}

	if len(bookOrderAfterSelectHooks) != 0 {
		for _, obj := range o {
			if err := obj.doAfterSelectHooks(ctx, exec); err != nil {
				return o, err
			}
		}
	}

	return o, nil
}

// Count returns the count of all BookOrder records in the query.
func (q bookOrderQuery) Count(ctx context.Context, exec boil.ContextExecutor) (int64, error) {
	var count int64

	queries.SetSelect(q.Query, nil)
	queries.SetCount(q.Query)

	err := q.Query.QueryRowContext(ctx, exec).Scan(&count)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: failed to count book_order rows")
	}

	return count, nil
}

// Exists checks if the row exists in the table.
func (q bookOrderQuery) Exists(ctx context.Context, exec boil.ContextExecutor) (bool, error) {
	var count int64

	queries.SetSelect(q.Query, nil)
	queries.SetCount(q.Query)
	queries.SetLimit(q.Query, 1)

	err := q.Query.QueryRowContext(ctx, exec).Scan(&count)
	if err != nil {
		return false, errors.Wrap(err, "dbmodels: failed to check if book_order exists")
	}

	return count > 0, nil
}

// Book pointed to by the foreign key.
func (o *BookOrder) Book(mods ...qm.QueryMod) bookQuery {
	queryMods := []qm.QueryMod{
		qm.Where("\"id\" = ?", o.BookID),
	}

	queryMods = append(queryMods, mods...)

	return Books(queryMods...)
}

// Order pointed to by the foreign key.
func (o *BookOrder) Order(mods ...qm.QueryMod) orderQuery {
	queryMods := []qm.QueryMod{
		qm.Where("\"id\" = ?", o.OrderID),
	}

	queryMods = append(queryMods, mods...)

	return Orders(queryMods...)
}

// LoadBook allows an eager lookup of values, cached into the
// loaded structs of the objects. This is for an N-1 relationship.
func (bookOrderL) LoadBook(ctx context.Context, e boil.ContextExecutor, singular bool, maybeBookOrder interface{}, mods queries.Applicator) error {
	var slice []*BookOrder
	var object *BookOrder

	if singular {
		var ok bool
		object, ok = maybeBookOrder.(*BookOrder)
		if !ok {
			object = new(BookOrder)
			ok = queries.SetFromEmbeddedStruct(&object, &maybeBookOrder)
			if !ok {
				return errors.New(fmt.Sprintf("failed to set %T from embedded struct %T", object, maybeBookOrder))
			}
		}
	} else {
		s, ok := maybeBookOrder.(*[]*BookOrder)
		if ok {
			slice = *s
		} else {
			ok = queries.SetFromEmbeddedStruct(&slice, maybeBookOrder)
			if !ok {
				return errors.New(fmt.Sprintf("failed to set %T from embedded struct %T", slice, maybeBookOrder))
			}
		}
	}

	args := make([]interface{}, 0, 1)
	if singular {
		if object.R == nil {
			object.R = &bookOrderR{}
		}
		args = append(args, object.BookID)

	} else {
	Outer:
		for _, obj := range slice {
			if obj.R == nil {
				obj.R = &bookOrderR{}
			}

			for _, a := range args {
				if a == obj.BookID {
					continue Outer
				}
			}

			args = append(args, obj.BookID)

		}
	}

	if len(args) == 0 {
		return nil
	}

	query := NewQuery(
		qm.From(`books`),
		qm.WhereIn(`books.id in ?`, args...),
	)
	if mods != nil {
		mods.Apply(query)
	}

	results, err := query.QueryContext(ctx, e)
	if err != nil {
		return errors.Wrap(err, "failed to eager load Book")
	}

	var resultSlice []*Book
	if err = queries.Bind(results, &resultSlice); err != nil {
		return errors.Wrap(err, "failed to bind eager loaded slice Book")
	}

	if err = results.Close(); err != nil {
		return errors.Wrap(err, "failed to close results of eager load for books")
	}
	if err = results.Err(); err != nil {
		return errors.Wrap(err, "error occurred during iteration of eager loaded relations for books")
	}

	if len(bookAfterSelectHooks) != 0 {
		for _, obj := range resultSlice {
			if err := obj.doAfterSelectHooks(ctx, e); err != nil {
				return err
			}
		}
	}

	if len(resultSlice) == 0 {
		return nil
	}

	if singular {
		foreign := resultSlice[0]
		object.R.Book = foreign
		if foreign.R == nil {
			foreign.R = &bookR{}
		}
		foreign.R.BookOrders = append(foreign.R.BookOrders, object)
		return nil
	}

	for _, local := range slice {
		for _, foreign := range resultSlice {
			if local.BookID == foreign.ID {
				local.R.Book = foreign
				if foreign.R == nil {
					foreign.R = &bookR{}
				}
				foreign.R.BookOrders = append(foreign.R.BookOrders, local)
				break
			}
		}
	}

	return nil
}

// LoadOrder allows an eager lookup of values, cached into the
// loaded structs of the objects. This is for an N-1 relationship.
func (bookOrderL) LoadOrder(ctx context.Context, e boil.ContextExecutor, singular bool, maybeBookOrder interface{}, mods queries.Applicator) error {
	var slice []*BookOrder
	var object *BookOrder

	if singular {
		var ok bool
		object, ok = maybeBookOrder.(*BookOrder)
		if !ok {
			object = new(BookOrder)
			ok = queries.SetFromEmbeddedStruct(&object, &maybeBookOrder)
			if !ok {
				return errors.New(fmt.Sprintf("failed to set %T from embedded struct %T", object, maybeBookOrder))
			}
		}
	} else {
		s, ok := maybeBookOrder.(*[]*BookOrder)
		if ok {
			slice = *s
		} else {
			ok = queries.SetFromEmbeddedStruct(&slice, maybeBookOrder)
			if !ok {
				return errors.New(fmt.Sprintf("failed to set %T from embedded struct %T", slice, maybeBookOrder))
			}
		}
	}

	args := make([]interface{}, 0, 1)
	if singular {
		if object.R == nil {
			object.R = &bookOrderR{}
		}
		args = append(args, object.OrderID)

	} else {
	Outer:
		for _, obj := range slice {
			if obj.R == nil {
				obj.R = &bookOrderR{}
			}

			for _, a := range args {
				if a == obj.OrderID {
					continue Outer
				}
			}

			args = append(args, obj.OrderID)

		}
	}

	if len(args) == 0 {
		return nil
	}

	query := NewQuery(
		qm.From(`orders`),
		qm.WhereIn(`orders.id in ?`, args...),
	)
	if mods != nil {
		mods.Apply(query)
	}

	results, err := query.QueryContext(ctx, e)
	if err != nil {
		return errors.Wrap(err, "failed to eager load Order")
	}

	var resultSlice []*Order
	if err = queries.Bind(results, &resultSlice); err != nil {
		return errors.Wrap(err, "failed to bind eager loaded slice Order")
	}

	if err = results.Close(); err != nil {
		return errors.Wrap(err, "failed to close results of eager load for orders")
	}
	if err = results.Err(); err != nil {
		return errors.Wrap(err, "error occurred during iteration of eager loaded relations for orders")
	}

	if len(orderAfterSelectHooks) != 0 {
		for _, obj := range resultSlice {
			if err := obj.doAfterSelectHooks(ctx, e); err != nil {
				return err
			}
		}
	}

	if len(resultSlice) == 0 {
		return nil
	}

	if singular {
		foreign := resultSlice[0]
		object.R.Order = foreign
		if foreign.R == nil {
			foreign.R = &orderR{}
		}
		foreign.R.BookOrders = append(foreign.R.BookOrders, object)
		return nil
	}

	for _, local := range slice {
		for _, foreign := range resultSlice {
			if local.OrderID == foreign.ID {
				local.R.Order = foreign
				if foreign.R == nil {
					foreign.R = &orderR{}
				}
				foreign.R.BookOrders = append(foreign.R.BookOrders, local)
				break
			}
		}
	}

	return nil
}

// SetBook of the bookOrder to the related item.
// Sets o.R.Book to related.
// Adds o to related.R.BookOrders.
func (o *BookOrder) SetBook(ctx context.Context, exec boil.ContextExecutor, insert bool, related *Book) error {
	var err error
	if insert {
		if err = related.Insert(ctx, exec, boil.Infer()); err != nil {
			return errors.Wrap(err, "failed to insert into foreign table")
		}
	}

	updateQuery := fmt.Sprintf(
		"UPDATE \"book_order\" SET %s WHERE %s",
		strmangle.SetParamNames("\"", "\"", 1, []string{"book_id"}),
		strmangle.WhereClause("\"", "\"", 2, bookOrderPrimaryKeyColumns),
	)
	values := []interface{}{related.ID, o.BookID, o.OrderID}

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, updateQuery)
		fmt.Fprintln(writer, values)
	}
	if _, err = exec.ExecContext(ctx, updateQuery, values...); err != nil {
		return errors.Wrap(err, "failed to update local table")
	}

	o.BookID = related.ID
	if o.R == nil {
		o.R = &bookOrderR{
			Book: related,
		}
	} else {
		o.R.Book = related
	}

	if related.R == nil {
		related.R = &bookR{
			BookOrders: BookOrderSlice{o},
		}
	} else {
		related.R.BookOrders = append(related.R.BookOrders, o)
	}

	return nil
}

// SetOrder of the bookOrder to the related item.
// Sets o.R.Order to related.
// Adds o to related.R.BookOrders.
func (o *BookOrder) SetOrder(ctx context.Context, exec boil.ContextExecutor, insert bool, related *Order) error {
	var err error
	if insert {
		if err = related.Insert(ctx, exec, boil.Infer()); err != nil {
			return errors.Wrap(err, "failed to insert into foreign table")
		}
	}

	updateQuery := fmt.Sprintf(
		"UPDATE \"book_order\" SET %s WHERE %s",
		strmangle.SetParamNames("\"", "\"", 1, []string{"order_id"}),
		strmangle.WhereClause("\"", "\"", 2, bookOrderPrimaryKeyColumns),
	)
	values := []interface{}{related.ID, o.BookID, o.OrderID}

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, updateQuery)
		fmt.Fprintln(writer, values)
	}
	if _, err = exec.ExecContext(ctx, updateQuery, values...); err != nil {
		return errors.Wrap(err, "failed to update local table")
	}

	o.OrderID = related.ID
	if o.R == nil {
		o.R = &bookOrderR{
			Order: related,
		}
	} else {
		o.R.Order = related
	}

	if related.R == nil {
		related.R = &orderR{
			BookOrders: BookOrderSlice{o},
		}
	} else {
		related.R.BookOrders = append(related.R.BookOrders, o)
	}

	return nil
}

// BookOrders retrieves all the records using an executor.
func BookOrders(mods ...qm.QueryMod) bookOrderQuery {
	mods = append(mods, qm.From("\"book_order\""))
	q := NewQuery(mods...)
	if len(queries.GetSelect(q)) == 0 {
		queries.SetSelect(q, []string{"\"book_order\".*"})
	}

	return bookOrderQuery{q}
}

// FindBookOrder retrieves a single record by ID with an executor.
// If selectCols is empty Find will return all columns.
func FindBookOrder(ctx context.Context, exec boil.ContextExecutor, bookID int64, orderID int64, selectCols ...string) (*BookOrder, error) {
	bookOrderObj := &BookOrder{}

	sel := "*"
	if len(selectCols) > 0 {
		sel = strings.Join(strmangle.IdentQuoteSlice(dialect.LQ, dialect.RQ, selectCols), ",")
	}
	query := fmt.Sprintf(
		"select %s from \"book_order\" where \"book_id\"=$1 AND \"order_id\"=$2", sel,
	)

	q := queries.Raw(query, bookID, orderID)

	err := q.Bind(ctx, exec, bookOrderObj)
	if err != nil {
		if errors.Is(err, sql.ErrNoRows) {
			return nil, sql.ErrNoRows
		}
		return nil, errors.Wrap(err, "dbmodels: unable to select from book_order")
	}

	if err = bookOrderObj.doAfterSelectHooks(ctx, exec); err != nil {
		return bookOrderObj, err
	}

	return bookOrderObj, nil
}

// Insert a single record using an executor.
// See boil.Columns.InsertColumnSet documentation to understand column list inference for inserts.
func (o *BookOrder) Insert(ctx context.Context, exec boil.ContextExecutor, columns boil.Columns) error {
	if o == nil {
		return errors.New("dbmodels: no book_order provided for insertion")
	}

	var err error

	if err := o.doBeforeInsertHooks(ctx, exec); err != nil {
		return err
	}

	nzDefaults := queries.NonZeroDefaultSet(bookOrderColumnsWithDefault, o)

	key := makeCacheKey(columns, nzDefaults)
	bookOrderInsertCacheMut.RLock()
	cache, cached := bookOrderInsertCache[key]
	bookOrderInsertCacheMut.RUnlock()

	if !cached {
		wl, returnColumns := columns.InsertColumnSet(
			bookOrderAllColumns,
			bookOrderColumnsWithDefault,
			bookOrderColumnsWithoutDefault,
			nzDefaults,
		)

		cache.valueMapping, err = queries.BindMapping(bookOrderType, bookOrderMapping, wl)
		if err != nil {
			return err
		}
		cache.retMapping, err = queries.BindMapping(bookOrderType, bookOrderMapping, returnColumns)
		if err != nil {
			return err
		}
		if len(wl) != 0 {
			cache.query = fmt.Sprintf("INSERT INTO \"book_order\" (\"%s\") %%sVALUES (%s)%%s", strings.Join(wl, "\",\""), strmangle.Placeholders(dialect.UseIndexPlaceholders, len(wl), 1, 1))
		} else {
			cache.query = "INSERT INTO \"book_order\" %sDEFAULT VALUES%s"
		}

		var queryOutput, queryReturning string

		if len(cache.retMapping) != 0 {
			queryReturning = fmt.Sprintf(" RETURNING \"%s\"", strings.Join(returnColumns, "\",\""))
		}

		cache.query = fmt.Sprintf(cache.query, queryOutput, queryReturning)
	}

	value := reflect.Indirect(reflect.ValueOf(o))
	vals := queries.ValuesFromMapping(value, cache.valueMapping)

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, cache.query)
		fmt.Fprintln(writer, vals)
	}

	if len(cache.retMapping) != 0 {
		err = exec.QueryRowContext(ctx, cache.query, vals...).Scan(queries.PtrsFromMapping(value, cache.retMapping)...)
	} else {
		_, err = exec.ExecContext(ctx, cache.query, vals...)
	}

	if err != nil {
		return errors.Wrap(err, "dbmodels: unable to insert into book_order")
	}

	if !cached {
		bookOrderInsertCacheMut.Lock()
		bookOrderInsertCache[key] = cache
		bookOrderInsertCacheMut.Unlock()
	}

	return o.doAfterInsertHooks(ctx, exec)
}

// Update uses an executor to update the BookOrder.
// See boil.Columns.UpdateColumnSet documentation to understand column list inference for updates.
// Update does not automatically update the record in case of default values. Use .Reload() to refresh the records.
func (o *BookOrder) Update(ctx context.Context, exec boil.ContextExecutor, columns boil.Columns) (int64, error) {
	var err error
	if err = o.doBeforeUpdateHooks(ctx, exec); err != nil {
		return 0, err
	}
	key := makeCacheKey(columns, nil)
	bookOrderUpdateCacheMut.RLock()
	cache, cached := bookOrderUpdateCache[key]
	bookOrderUpdateCacheMut.RUnlock()

	if !cached {
		wl := columns.UpdateColumnSet(
			bookOrderAllColumns,
			bookOrderPrimaryKeyColumns,
		)

		if !columns.IsWhitelist() {
			wl = strmangle.SetComplement(wl, []string{"created_at"})
		}
		if len(wl) == 0 {
			return 0, errors.New("dbmodels: unable to update book_order, could not build whitelist")
		}

		cache.query = fmt.Sprintf("UPDATE \"book_order\" SET %s WHERE %s",
			strmangle.SetParamNames("\"", "\"", 1, wl),
			strmangle.WhereClause("\"", "\"", len(wl)+1, bookOrderPrimaryKeyColumns),
		)
		cache.valueMapping, err = queries.BindMapping(bookOrderType, bookOrderMapping, append(wl, bookOrderPrimaryKeyColumns...))
		if err != nil {
			return 0, err
		}
	}

	values := queries.ValuesFromMapping(reflect.Indirect(reflect.ValueOf(o)), cache.valueMapping)

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, cache.query)
		fmt.Fprintln(writer, values)
	}
	var result sql.Result
	result, err = exec.ExecContext(ctx, cache.query, values...)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to update book_order row")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: failed to get rows affected by update for book_order")
	}

	if !cached {
		bookOrderUpdateCacheMut.Lock()
		bookOrderUpdateCache[key] = cache
		bookOrderUpdateCacheMut.Unlock()
	}

	return rowsAff, o.doAfterUpdateHooks(ctx, exec)
}

// UpdateAll updates all rows with the specified column values.
func (q bookOrderQuery) UpdateAll(ctx context.Context, exec boil.ContextExecutor, cols M) (int64, error) {
	queries.SetUpdate(q.Query, cols)

	result, err := q.Query.ExecContext(ctx, exec)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to update all for book_order")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to retrieve rows affected for book_order")
	}

	return rowsAff, nil
}

// UpdateAll updates all rows with the specified column values, using an executor.
func (o BookOrderSlice) UpdateAll(ctx context.Context, exec boil.ContextExecutor, cols M) (int64, error) {
	ln := int64(len(o))
	if ln == 0 {
		return 0, nil
	}

	if len(cols) == 0 {
		return 0, errors.New("dbmodels: update all requires at least one column argument")
	}

	colNames := make([]string, len(cols))
	args := make([]interface{}, len(cols))

	i := 0
	for name, value := range cols {
		colNames[i] = name
		args[i] = value
		i++
	}

	// Append all of the primary key values for each column
	for _, obj := range o {
		pkeyArgs := queries.ValuesFromMapping(reflect.Indirect(reflect.ValueOf(obj)), bookOrderPrimaryKeyMapping)
		args = append(args, pkeyArgs...)
	}

	sql := fmt.Sprintf("UPDATE \"book_order\" SET %s WHERE %s",
		strmangle.SetParamNames("\"", "\"", 1, colNames),
		strmangle.WhereClauseRepeated(string(dialect.LQ), string(dialect.RQ), len(colNames)+1, bookOrderPrimaryKeyColumns, len(o)))

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, sql)
		fmt.Fprintln(writer, args...)
	}
	result, err := exec.ExecContext(ctx, sql, args...)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to update all in bookOrder slice")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to retrieve rows affected all in update all bookOrder")
	}
	return rowsAff, nil
}

// Upsert attempts an insert using an executor, and does an update or ignore on conflict.
// See boil.Columns documentation for how to properly use updateColumns and insertColumns.
func (o *BookOrder) Upsert(ctx context.Context, exec boil.ContextExecutor, updateOnConflict bool, conflictColumns []string, updateColumns, insertColumns boil.Columns) error {
	if o == nil {
		return errors.New("dbmodels: no book_order provided for upsert")
	}

	if err := o.doBeforeUpsertHooks(ctx, exec); err != nil {
		return err
	}

	nzDefaults := queries.NonZeroDefaultSet(bookOrderColumnsWithDefault, o)

	// Build cache key in-line uglily - mysql vs psql problems
	buf := strmangle.GetBuffer()
	if updateOnConflict {
		buf.WriteByte('t')
	} else {
		buf.WriteByte('f')
	}
	buf.WriteByte('.')
	for _, c := range conflictColumns {
		buf.WriteString(c)
	}
	buf.WriteByte('.')
	buf.WriteString(strconv.Itoa(updateColumns.Kind))
	for _, c := range updateColumns.Cols {
		buf.WriteString(c)
	}
	buf.WriteByte('.')
	buf.WriteString(strconv.Itoa(insertColumns.Kind))
	for _, c := range insertColumns.Cols {
		buf.WriteString(c)
	}
	buf.WriteByte('.')
	for _, c := range nzDefaults {
		buf.WriteString(c)
	}
	key := buf.String()
	strmangle.PutBuffer(buf)

	bookOrderUpsertCacheMut.RLock()
	cache, cached := bookOrderUpsertCache[key]
	bookOrderUpsertCacheMut.RUnlock()

	var err error

	if !cached {
		insert, ret := insertColumns.InsertColumnSet(
			bookOrderAllColumns,
			bookOrderColumnsWithDefault,
			bookOrderColumnsWithoutDefault,
			nzDefaults,
		)

		update := updateColumns.UpdateColumnSet(
			bookOrderAllColumns,
			bookOrderPrimaryKeyColumns,
		)

		if updateOnConflict && len(update) == 0 {
			return errors.New("dbmodels: unable to upsert book_order, could not build update column list")
		}

		conflict := conflictColumns
		if len(conflict) == 0 {
			conflict = make([]string, len(bookOrderPrimaryKeyColumns))
			copy(conflict, bookOrderPrimaryKeyColumns)
		}
		cache.query = buildUpsertQueryPostgres(dialect, "\"book_order\"", updateOnConflict, ret, update, conflict, insert)

		cache.valueMapping, err = queries.BindMapping(bookOrderType, bookOrderMapping, insert)
		if err != nil {
			return err
		}
		if len(ret) != 0 {
			cache.retMapping, err = queries.BindMapping(bookOrderType, bookOrderMapping, ret)
			if err != nil {
				return err
			}
		}
	}

	value := reflect.Indirect(reflect.ValueOf(o))
	vals := queries.ValuesFromMapping(value, cache.valueMapping)
	var returns []interface{}
	if len(cache.retMapping) != 0 {
		returns = queries.PtrsFromMapping(value, cache.retMapping)
	}

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, cache.query)
		fmt.Fprintln(writer, vals)
	}
	if len(cache.retMapping) != 0 {
		err = exec.QueryRowContext(ctx, cache.query, vals...).Scan(returns...)
		if errors.Is(err, sql.ErrNoRows) {
			err = nil // Postgres doesn't return anything when there's no update
		}
	} else {
		_, err = exec.ExecContext(ctx, cache.query, vals...)
	}
	if err != nil {
		return errors.Wrap(err, "dbmodels: unable to upsert book_order")
	}

	if !cached {
		bookOrderUpsertCacheMut.Lock()
		bookOrderUpsertCache[key] = cache
		bookOrderUpsertCacheMut.Unlock()
	}

	return o.doAfterUpsertHooks(ctx, exec)
}

// Delete deletes a single BookOrder record with an executor.
// Delete will match against the primary key column to find the record to delete.
func (o *BookOrder) Delete(ctx context.Context, exec boil.ContextExecutor) (int64, error) {
	if o == nil {
		return 0, errors.New("dbmodels: no BookOrder provided for delete")
	}

	if err := o.doBeforeDeleteHooks(ctx, exec); err != nil {
		return 0, err
	}

	args := queries.ValuesFromMapping(reflect.Indirect(reflect.ValueOf(o)), bookOrderPrimaryKeyMapping)
	sql := "DELETE FROM \"book_order\" WHERE \"book_id\"=$1 AND \"order_id\"=$2"

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, sql)
		fmt.Fprintln(writer, args...)
	}
	result, err := exec.ExecContext(ctx, sql, args...)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to delete from book_order")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: failed to get rows affected by delete for book_order")
	}

	if err := o.doAfterDeleteHooks(ctx, exec); err != nil {
		return 0, err
	}

	return rowsAff, nil
}

// DeleteAll deletes all matching rows.
func (q bookOrderQuery) DeleteAll(ctx context.Context, exec boil.ContextExecutor) (int64, error) {
	if q.Query == nil {
		return 0, errors.New("dbmodels: no bookOrderQuery provided for delete all")
	}

	queries.SetDelete(q.Query)

	result, err := q.Query.ExecContext(ctx, exec)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to delete all from book_order")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: failed to get rows affected by deleteall for book_order")
	}

	return rowsAff, nil
}

// DeleteAll deletes all rows in the slice, using an executor.
func (o BookOrderSlice) DeleteAll(ctx context.Context, exec boil.ContextExecutor) (int64, error) {
	if len(o) == 0 {
		return 0, nil
	}

	if len(bookOrderBeforeDeleteHooks) != 0 {
		for _, obj := range o {
			if err := obj.doBeforeDeleteHooks(ctx, exec); err != nil {
				return 0, err
			}
		}
	}

	var args []interface{}
	for _, obj := range o {
		pkeyArgs := queries.ValuesFromMapping(reflect.Indirect(reflect.ValueOf(obj)), bookOrderPrimaryKeyMapping)
		args = append(args, pkeyArgs...)
	}

	sql := "DELETE FROM \"book_order\" WHERE " +
		strmangle.WhereClauseRepeated(string(dialect.LQ), string(dialect.RQ), 1, bookOrderPrimaryKeyColumns, len(o))

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, sql)
		fmt.Fprintln(writer, args)
	}
	result, err := exec.ExecContext(ctx, sql, args...)
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: unable to delete all from bookOrder slice")
	}

	rowsAff, err := result.RowsAffected()
	if err != nil {
		return 0, errors.Wrap(err, "dbmodels: failed to get rows affected by deleteall for book_order")
	}

	if len(bookOrderAfterDeleteHooks) != 0 {
		for _, obj := range o {
			if err := obj.doAfterDeleteHooks(ctx, exec); err != nil {
				return 0, err
			}
		}
	}

	return rowsAff, nil
}

// Reload refetches the object from the database
// using the primary keys with an executor.
func (o *BookOrder) Reload(ctx context.Context, exec boil.ContextExecutor) error {
	ret, err := FindBookOrder(ctx, exec, o.BookID, o.OrderID)
	if err != nil {
		return err
	}

	*o = *ret
	return nil
}

// ReloadAll refetches every row with matching primary key column values
// and overwrites the original object slice with the newly updated slice.
func (o *BookOrderSlice) ReloadAll(ctx context.Context, exec boil.ContextExecutor) error {
	if o == nil || len(*o) == 0 {
		return nil
	}

	slice := BookOrderSlice{}
	var args []interface{}
	for _, obj := range *o {
		pkeyArgs := queries.ValuesFromMapping(reflect.Indirect(reflect.ValueOf(obj)), bookOrderPrimaryKeyMapping)
		args = append(args, pkeyArgs...)
	}

	sql := "SELECT \"book_order\".* FROM \"book_order\" WHERE " +
		strmangle.WhereClauseRepeated(string(dialect.LQ), string(dialect.RQ), 1, bookOrderPrimaryKeyColumns, len(*o))

	q := queries.Raw(sql, args...)

	err := q.Bind(ctx, exec, &slice)
	if err != nil {
		return errors.Wrap(err, "dbmodels: unable to reload all in BookOrderSlice")
	}

	*o = slice

	return nil
}

// BookOrderExists checks if the BookOrder row exists.
func BookOrderExists(ctx context.Context, exec boil.ContextExecutor, bookID int64, orderID int64) (bool, error) {
	var exists bool
	sql := "select exists(select 1 from \"book_order\" where \"book_id\"=$1 AND \"order_id\"=$2 limit 1)"

	if boil.IsDebug(ctx) {
		writer := boil.DebugWriterFrom(ctx)
		fmt.Fprintln(writer, sql)
		fmt.Fprintln(writer, bookID, orderID)
	}
	row := exec.QueryRowContext(ctx, sql, bookID, orderID)

	err := row.Scan(&exists)
	if err != nil {
		return false, errors.Wrap(err, "dbmodels: unable to check if book_order exists")
	}

	return exists, nil
}

// Exists checks if the BookOrder row exists.
func (o *BookOrder) Exists(ctx context.Context, exec boil.ContextExecutor) (bool, error) {
	return BookOrderExists(ctx, exec, o.BookID, o.OrderID)
}

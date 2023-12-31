// Code generated by SQLBoiler 4.15.0 (https://github.com/volatiletech/sqlboiler). DO NOT EDIT.
// This file is meant to be re-generated in place and/or deleted at any time.

package dbmodels

import (
	"bytes"
	"context"
	"reflect"
	"testing"

	"github.com/volatiletech/randomize"
	"github.com/volatiletech/sqlboiler/v4/boil"
	"github.com/volatiletech/sqlboiler/v4/queries"
	"github.com/volatiletech/strmangle"
)

var (
	// Relationships sometimes use the reflection helper queries.Equal/queries.Assign
	// so force a package dependency in case they don't.
	_ = queries.Equal
)

func testDiscounts(t *testing.T) {
	t.Parallel()

	query := Discounts()

	if query.Query == nil {
		t.Error("expected a query, got nothing")
	}
}

func testDiscountsDelete(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	if rowsAff, err := o.Delete(ctx, tx); err != nil {
		t.Error(err)
	} else if rowsAff != 1 {
		t.Error("should only have deleted one row, but affected:", rowsAff)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 0 {
		t.Error("want zero records, got:", count)
	}
}

func testDiscountsQueryDeleteAll(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	if rowsAff, err := Discounts().DeleteAll(ctx, tx); err != nil {
		t.Error(err)
	} else if rowsAff != 1 {
		t.Error("should only have deleted one row, but affected:", rowsAff)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 0 {
		t.Error("want zero records, got:", count)
	}
}

func testDiscountsSliceDeleteAll(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	slice := DiscountSlice{o}

	if rowsAff, err := slice.DeleteAll(ctx, tx); err != nil {
		t.Error(err)
	} else if rowsAff != 1 {
		t.Error("should only have deleted one row, but affected:", rowsAff)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 0 {
		t.Error("want zero records, got:", count)
	}
}

func testDiscountsExists(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	e, err := DiscountExists(ctx, tx, o.ID)
	if err != nil {
		t.Errorf("Unable to check if Discount exists: %s", err)
	}
	if !e {
		t.Errorf("Expected DiscountExists to return true, but got false.")
	}
}

func testDiscountsFind(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	discountFound, err := FindDiscount(ctx, tx, o.ID)
	if err != nil {
		t.Error(err)
	}

	if discountFound == nil {
		t.Error("want a record, got nil")
	}
}

func testDiscountsBind(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	if err = Discounts().Bind(ctx, tx, o); err != nil {
		t.Error(err)
	}
}

func testDiscountsOne(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	if x, err := Discounts().One(ctx, tx); err != nil {
		t.Error(err)
	} else if x == nil {
		t.Error("expected to get a non nil record")
	}
}

func testDiscountsAll(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	discountOne := &Discount{}
	discountTwo := &Discount{}
	if err = randomize.Struct(seed, discountOne, discountDBTypes, false, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}
	if err = randomize.Struct(seed, discountTwo, discountDBTypes, false, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = discountOne.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}
	if err = discountTwo.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	slice, err := Discounts().All(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if len(slice) != 2 {
		t.Error("want 2 records, got:", len(slice))
	}
}

func testDiscountsCount(t *testing.T) {
	t.Parallel()

	var err error
	seed := randomize.NewSeed()
	discountOne := &Discount{}
	discountTwo := &Discount{}
	if err = randomize.Struct(seed, discountOne, discountDBTypes, false, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}
	if err = randomize.Struct(seed, discountTwo, discountDBTypes, false, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = discountOne.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}
	if err = discountTwo.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 2 {
		t.Error("want 2 records, got:", count)
	}
}

func discountBeforeInsertHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountAfterInsertHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountAfterSelectHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountBeforeUpdateHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountAfterUpdateHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountBeforeDeleteHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountAfterDeleteHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountBeforeUpsertHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func discountAfterUpsertHook(ctx context.Context, e boil.ContextExecutor, o *Discount) error {
	*o = Discount{}
	return nil
}

func testDiscountsHooks(t *testing.T) {
	t.Parallel()

	var err error

	ctx := context.Background()
	empty := &Discount{}
	o := &Discount{}

	seed := randomize.NewSeed()
	if err = randomize.Struct(seed, o, discountDBTypes, false); err != nil {
		t.Errorf("Unable to randomize Discount object: %s", err)
	}

	AddDiscountHook(boil.BeforeInsertHook, discountBeforeInsertHook)
	if err = o.doBeforeInsertHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doBeforeInsertHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected BeforeInsertHook function to empty object, but got: %#v", o)
	}
	discountBeforeInsertHooks = []DiscountHook{}

	AddDiscountHook(boil.AfterInsertHook, discountAfterInsertHook)
	if err = o.doAfterInsertHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doAfterInsertHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected AfterInsertHook function to empty object, but got: %#v", o)
	}
	discountAfterInsertHooks = []DiscountHook{}

	AddDiscountHook(boil.AfterSelectHook, discountAfterSelectHook)
	if err = o.doAfterSelectHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doAfterSelectHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected AfterSelectHook function to empty object, but got: %#v", o)
	}
	discountAfterSelectHooks = []DiscountHook{}

	AddDiscountHook(boil.BeforeUpdateHook, discountBeforeUpdateHook)
	if err = o.doBeforeUpdateHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doBeforeUpdateHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected BeforeUpdateHook function to empty object, but got: %#v", o)
	}
	discountBeforeUpdateHooks = []DiscountHook{}

	AddDiscountHook(boil.AfterUpdateHook, discountAfterUpdateHook)
	if err = o.doAfterUpdateHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doAfterUpdateHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected AfterUpdateHook function to empty object, but got: %#v", o)
	}
	discountAfterUpdateHooks = []DiscountHook{}

	AddDiscountHook(boil.BeforeDeleteHook, discountBeforeDeleteHook)
	if err = o.doBeforeDeleteHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doBeforeDeleteHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected BeforeDeleteHook function to empty object, but got: %#v", o)
	}
	discountBeforeDeleteHooks = []DiscountHook{}

	AddDiscountHook(boil.AfterDeleteHook, discountAfterDeleteHook)
	if err = o.doAfterDeleteHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doAfterDeleteHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected AfterDeleteHook function to empty object, but got: %#v", o)
	}
	discountAfterDeleteHooks = []DiscountHook{}

	AddDiscountHook(boil.BeforeUpsertHook, discountBeforeUpsertHook)
	if err = o.doBeforeUpsertHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doBeforeUpsertHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected BeforeUpsertHook function to empty object, but got: %#v", o)
	}
	discountBeforeUpsertHooks = []DiscountHook{}

	AddDiscountHook(boil.AfterUpsertHook, discountAfterUpsertHook)
	if err = o.doAfterUpsertHooks(ctx, nil); err != nil {
		t.Errorf("Unable to execute doAfterUpsertHooks: %s", err)
	}
	if !reflect.DeepEqual(o, empty) {
		t.Errorf("Expected AfterUpsertHook function to empty object, but got: %#v", o)
	}
	discountAfterUpsertHooks = []DiscountHook{}
}

func testDiscountsInsert(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 1 {
		t.Error("want one record, got:", count)
	}
}

func testDiscountsInsertWhitelist(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Whitelist(discountColumnsWithoutDefault...)); err != nil {
		t.Error(err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 1 {
		t.Error("want one record, got:", count)
	}
}

func testDiscountToManyOrders(t *testing.T) {
	var err error
	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()

	var a Discount
	var b, c Order

	seed := randomize.NewSeed()
	if err = randomize.Struct(seed, &a, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	if err := a.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}

	if err = randomize.Struct(seed, &b, orderDBTypes, false, orderColumnsWithDefault...); err != nil {
		t.Fatal(err)
	}
	if err = randomize.Struct(seed, &c, orderDBTypes, false, orderColumnsWithDefault...); err != nil {
		t.Fatal(err)
	}

	if err = b.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}
	if err = c.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}

	_, err = tx.Exec("insert into \"order_discount\" (\"discount_id\", \"order_id\") values ($1, $2)", a.ID, b.ID)
	if err != nil {
		t.Fatal(err)
	}
	_, err = tx.Exec("insert into \"order_discount\" (\"discount_id\", \"order_id\") values ($1, $2)", a.ID, c.ID)
	if err != nil {
		t.Fatal(err)
	}

	check, err := a.Orders().All(ctx, tx)
	if err != nil {
		t.Fatal(err)
	}

	bFound, cFound := false, false
	for _, v := range check {
		if v.ID == b.ID {
			bFound = true
		}
		if v.ID == c.ID {
			cFound = true
		}
	}

	if !bFound {
		t.Error("expected to find b")
	}
	if !cFound {
		t.Error("expected to find c")
	}

	slice := DiscountSlice{&a}
	if err = a.L.LoadOrders(ctx, tx, false, (*[]*Discount)(&slice), nil); err != nil {
		t.Fatal(err)
	}
	if got := len(a.R.Orders); got != 2 {
		t.Error("number of eager loaded records wrong, got:", got)
	}

	a.R.Orders = nil
	if err = a.L.LoadOrders(ctx, tx, true, &a, nil); err != nil {
		t.Fatal(err)
	}
	if got := len(a.R.Orders); got != 2 {
		t.Error("number of eager loaded records wrong, got:", got)
	}

	if t.Failed() {
		t.Logf("%#v", check)
	}
}

func testDiscountToManyAddOpOrders(t *testing.T) {
	var err error

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()

	var a Discount
	var b, c, d, e Order

	seed := randomize.NewSeed()
	if err = randomize.Struct(seed, &a, discountDBTypes, false, strmangle.SetComplement(discountPrimaryKeyColumns, discountColumnsWithoutDefault)...); err != nil {
		t.Fatal(err)
	}
	foreigners := []*Order{&b, &c, &d, &e}
	for _, x := range foreigners {
		if err = randomize.Struct(seed, x, orderDBTypes, false, strmangle.SetComplement(orderPrimaryKeyColumns, orderColumnsWithoutDefault)...); err != nil {
			t.Fatal(err)
		}
	}

	if err := a.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}
	if err = b.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}
	if err = c.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}

	foreignersSplitByInsertion := [][]*Order{
		{&b, &c},
		{&d, &e},
	}

	for i, x := range foreignersSplitByInsertion {
		err = a.AddOrders(ctx, tx, i != 0, x...)
		if err != nil {
			t.Fatal(err)
		}

		first := x[0]
		second := x[1]

		if first.R.Discounts[0] != &a {
			t.Error("relationship was not added properly to the slice")
		}
		if second.R.Discounts[0] != &a {
			t.Error("relationship was not added properly to the slice")
		}

		if a.R.Orders[i*2] != first {
			t.Error("relationship struct slice not set to correct value")
		}
		if a.R.Orders[i*2+1] != second {
			t.Error("relationship struct slice not set to correct value")
		}

		count, err := a.Orders().Count(ctx, tx)
		if err != nil {
			t.Fatal(err)
		}
		if want := int64((i + 1) * 2); count != want {
			t.Error("want", want, "got", count)
		}
	}
}

func testDiscountToManySetOpOrders(t *testing.T) {
	var err error

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()

	var a Discount
	var b, c, d, e Order

	seed := randomize.NewSeed()
	if err = randomize.Struct(seed, &a, discountDBTypes, false, strmangle.SetComplement(discountPrimaryKeyColumns, discountColumnsWithoutDefault)...); err != nil {
		t.Fatal(err)
	}
	foreigners := []*Order{&b, &c, &d, &e}
	for _, x := range foreigners {
		if err = randomize.Struct(seed, x, orderDBTypes, false, strmangle.SetComplement(orderPrimaryKeyColumns, orderColumnsWithoutDefault)...); err != nil {
			t.Fatal(err)
		}
	}

	if err = a.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}
	if err = b.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}
	if err = c.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}

	err = a.SetOrders(ctx, tx, false, &b, &c)
	if err != nil {
		t.Fatal(err)
	}

	count, err := a.Orders().Count(ctx, tx)
	if err != nil {
		t.Fatal(err)
	}
	if count != 2 {
		t.Error("count was wrong:", count)
	}

	err = a.SetOrders(ctx, tx, true, &d, &e)
	if err != nil {
		t.Fatal(err)
	}

	count, err = a.Orders().Count(ctx, tx)
	if err != nil {
		t.Fatal(err)
	}
	if count != 2 {
		t.Error("count was wrong:", count)
	}

	// The following checks cannot be implemented since we have no handle
	// to these when we call Set(). Leaving them here as wishful thinking
	// and to let people know there's dragons.
	//
	// if len(b.R.Discounts) != 0 {
	// 	t.Error("relationship was not removed properly from the slice")
	// }
	// if len(c.R.Discounts) != 0 {
	// 	t.Error("relationship was not removed properly from the slice")
	// }
	if d.R.Discounts[0] != &a {
		t.Error("relationship was not added properly to the slice")
	}
	if e.R.Discounts[0] != &a {
		t.Error("relationship was not added properly to the slice")
	}

	if a.R.Orders[0] != &d {
		t.Error("relationship struct slice not set to correct value")
	}
	if a.R.Orders[1] != &e {
		t.Error("relationship struct slice not set to correct value")
	}
}

func testDiscountToManyRemoveOpOrders(t *testing.T) {
	var err error

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()

	var a Discount
	var b, c, d, e Order

	seed := randomize.NewSeed()
	if err = randomize.Struct(seed, &a, discountDBTypes, false, strmangle.SetComplement(discountPrimaryKeyColumns, discountColumnsWithoutDefault)...); err != nil {
		t.Fatal(err)
	}
	foreigners := []*Order{&b, &c, &d, &e}
	for _, x := range foreigners {
		if err = randomize.Struct(seed, x, orderDBTypes, false, strmangle.SetComplement(orderPrimaryKeyColumns, orderColumnsWithoutDefault)...); err != nil {
			t.Fatal(err)
		}
	}

	if err := a.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Fatal(err)
	}

	err = a.AddOrders(ctx, tx, true, foreigners...)
	if err != nil {
		t.Fatal(err)
	}

	count, err := a.Orders().Count(ctx, tx)
	if err != nil {
		t.Fatal(err)
	}
	if count != 4 {
		t.Error("count was wrong:", count)
	}

	err = a.RemoveOrders(ctx, tx, foreigners[:2]...)
	if err != nil {
		t.Fatal(err)
	}

	count, err = a.Orders().Count(ctx, tx)
	if err != nil {
		t.Fatal(err)
	}
	if count != 2 {
		t.Error("count was wrong:", count)
	}

	if len(b.R.Discounts) != 0 {
		t.Error("relationship was not removed properly from the slice")
	}
	if len(c.R.Discounts) != 0 {
		t.Error("relationship was not removed properly from the slice")
	}
	if d.R.Discounts[0] != &a {
		t.Error("relationship was not added properly to the foreign struct")
	}
	if e.R.Discounts[0] != &a {
		t.Error("relationship was not added properly to the foreign struct")
	}

	if len(a.R.Orders) != 2 {
		t.Error("should have preserved two relationships")
	}

	// Removal doesn't do a stable deletion for performance so we have to flip the order
	if a.R.Orders[1] != &d {
		t.Error("relationship to d should have been preserved")
	}
	if a.R.Orders[0] != &e {
		t.Error("relationship to e should have been preserved")
	}
}

func testDiscountsReload(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	if err = o.Reload(ctx, tx); err != nil {
		t.Error(err)
	}
}

func testDiscountsReloadAll(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	slice := DiscountSlice{o}

	if err = slice.ReloadAll(ctx, tx); err != nil {
		t.Error(err)
	}
}

func testDiscountsSelect(t *testing.T) {
	t.Parallel()

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	slice, err := Discounts().All(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if len(slice) != 1 {
		t.Error("want one record, got:", len(slice))
	}
}

var (
	discountDBTypes = map[string]string{`ID`: `bigint`, `Type`: `enum.discount_type('percent','value')`, `Value`: `integer`}
	_               = bytes.MinRead
)

func testDiscountsUpdate(t *testing.T) {
	t.Parallel()

	if 0 == len(discountPrimaryKeyColumns) {
		t.Skip("Skipping table with no primary key columns")
	}
	if len(discountAllColumns) == len(discountPrimaryKeyColumns) {
		t.Skip("Skipping table with only primary key columns")
	}

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 1 {
		t.Error("want one record, got:", count)
	}

	if err = randomize.Struct(seed, o, discountDBTypes, true, discountPrimaryKeyColumns...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	if rowsAff, err := o.Update(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	} else if rowsAff != 1 {
		t.Error("should only affect one row but affected", rowsAff)
	}
}

func testDiscountsSliceUpdateAll(t *testing.T) {
	t.Parallel()

	if len(discountAllColumns) == len(discountPrimaryKeyColumns) {
		t.Skip("Skipping table with only primary key columns")
	}

	seed := randomize.NewSeed()
	var err error
	o := &Discount{}
	if err = randomize.Struct(seed, o, discountDBTypes, true, discountColumnsWithDefault...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Insert(ctx, tx, boil.Infer()); err != nil {
		t.Error(err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}

	if count != 1 {
		t.Error("want one record, got:", count)
	}

	if err = randomize.Struct(seed, o, discountDBTypes, true, discountPrimaryKeyColumns...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	// Remove Primary keys and unique columns from what we plan to update
	var fields []string
	if strmangle.StringSliceMatch(discountAllColumns, discountPrimaryKeyColumns) {
		fields = discountAllColumns
	} else {
		fields = strmangle.SetComplement(
			discountAllColumns,
			discountPrimaryKeyColumns,
		)
	}

	value := reflect.Indirect(reflect.ValueOf(o))
	typ := reflect.TypeOf(o).Elem()
	n := typ.NumField()

	updateMap := M{}
	for _, col := range fields {
		for i := 0; i < n; i++ {
			f := typ.Field(i)
			if f.Tag.Get("boil") == col {
				updateMap[col] = value.Field(i).Interface()
			}
		}
	}

	slice := DiscountSlice{o}
	if rowsAff, err := slice.UpdateAll(ctx, tx, updateMap); err != nil {
		t.Error(err)
	} else if rowsAff != 1 {
		t.Error("wanted one record updated but got", rowsAff)
	}
}

func testDiscountsUpsert(t *testing.T) {
	t.Parallel()

	if len(discountAllColumns) == len(discountPrimaryKeyColumns) {
		t.Skip("Skipping table with only primary key columns")
	}

	seed := randomize.NewSeed()
	var err error
	// Attempt the INSERT side of an UPSERT
	o := Discount{}
	if err = randomize.Struct(seed, &o, discountDBTypes, true); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	ctx := context.Background()
	tx := MustTx(boil.BeginTx(ctx, nil))
	defer func() { _ = tx.Rollback() }()
	if err = o.Upsert(ctx, tx, false, nil, boil.Infer(), boil.Infer()); err != nil {
		t.Errorf("Unable to upsert Discount: %s", err)
	}

	count, err := Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}
	if count != 1 {
		t.Error("want one record, got:", count)
	}

	// Attempt the UPDATE side of an UPSERT
	if err = randomize.Struct(seed, &o, discountDBTypes, false, discountPrimaryKeyColumns...); err != nil {
		t.Errorf("Unable to randomize Discount struct: %s", err)
	}

	if err = o.Upsert(ctx, tx, true, nil, boil.Infer(), boil.Infer()); err != nil {
		t.Errorf("Unable to upsert Discount: %s", err)
	}

	count, err = Discounts().Count(ctx, tx)
	if err != nil {
		t.Error(err)
	}
	if count != 1 {
		t.Error("want one record, got:", count)
	}
}

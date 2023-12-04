DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS books CASCADE;
DROP TABLE IF EXISTS book_categories CASCADE;
DROP TABLE IF EXISTS book_order CASCADE;
DROP TABLE IF EXISTS orders CASCADE;
DROP TABLE IF EXISTS discounts CASCADE;
DROP TABLE IF EXISTS order_discount CASCADE;

CREATE TYPE "discount_type" AS ENUM (
  'percent',
  'value'
);

CREATE TABLE "users" (
                         "username" varchar(250) primary key not null check ( users.username <> '' ),
                         "password" text not null check ( octet_length(users.password) <> 0  )
);

CREATE TABLE "books" (
                         "id" bigserial primary key,
                         "category_id" bigserial,
                         "name" varchar(250) not null check ( books.name <> '' ),
                         "author" varchar(250) not null check ( books.author <> '' ),
                         "sku" varchar(50) not null check ( books.sku <> '' ),
                         "desc" text,
                         "image" text,
                         "price" int not null check ( books.price > 0 ),
                         "total_sold" int not null default 0,
                         "quantity" int not null default 0,
                         "status" boolean not null default true
);

CREATE TABLE "book_categories" (
                                   "id" bigserial primary key,
                                   "name" varchar(250) not null check ( book_categories.name <> '' )
);

CREATE TABLE "book_order" (
                              "book_id" bigserial,
                              "order_id" bigserial,
                              primary key ("book_id", "order_id")
);

CREATE TABLE "orders" (
                          "id" bigserial primary key ,
                          "created_at" timestamp with time zone not null default now(),
                          "total" int not null,
                          "status" boolean not null default true
);

CREATE TABLE "discounts" (
                             "id" bigserial primary key ,
                             "type" discount_type not null,
                             "value" int not null check ( discounts.value > 0 )
);

CREATE TABLE "order_discount" (
                                  "order_id" bigserial,
                                  "discount_id" bigserial,
                                  primary key ("order_id", "discount_id")
);

ALTER TABLE "books" ADD FOREIGN KEY ("category_id") REFERENCES "book_categories" ("id");

ALTER TABLE "book_order" ADD FOREIGN KEY ("book_id") REFERENCES "books" ("id");

ALTER TABLE "book_order" ADD FOREIGN KEY ("order_id") REFERENCES "orders" ("id");

ALTER TABLE "order_discount" ADD FOREIGN KEY ("order_id") REFERENCES "orders" ("id");

ALTER TABLE "order_discount" ADD FOREIGN KEY ("discount_id") REFERENCES "discounts" ("id");

ALTER TABLE book_order ADD COLUMN quantity int not null default 1 check ( quantity > 0 ) ;

ALTER TABLE books DROP COLUMN sku;
ALTER TABLE books DROP COLUMN image;

ALTER TABLE books DROP CONSTRAINT books_category_id_fkey;
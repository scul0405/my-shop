# Create PostgreSQL database at local

### Step1: Install PostgreSQL
[Click here](https://www.postgresql.org/download/)

### Step2: Open SQL Shell (psql)
Go to:
```sh
PostgreSQL/your-psql-version/scripts/runpsql.bat
``` 

### Step 3: Create account for database
```sh
CREATE USER admin with PASSWORD 'secret';
```

### Step 4: Create database
```sh
CREATE DATABASE book_db;
```

### Step 5: Grant connect and privileges to user
```sh
GRANT CONNECT ON DATABASE book_db TO admin;
GRANT ALL PRIVILEGES ON DATABASE book_db TO admin;
ALTER DATABASE book_db OWNER TO admin;
```
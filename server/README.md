# LẬP TRÌNH WINDOWS - 21_3
## BACKEND SERVER

## Quick usage
>**_NOTE:_** Current instruction only work for macOS/linux or windows 
> but has renamed mingw32-make to make. If your device not work, you can
> go to Makefile to copy and run it on terminal.

- Install packages
```shell
make tidy
```

- Migrate data:
```shell
make migrate-up
```

- Run server:
```shell
make run
```

## Set up local development
- [TablePlus](https://tableplus.com/)
- [Golang](https://golang.org/)
- [Migrate](https://github.com/golang-migrate/migrate/tree/master/cmd/migrate)

## Documentation

### Swagger UI
[http://localhost:8080/swagger/index.html](http://localhost:8080/swagger/index.html)
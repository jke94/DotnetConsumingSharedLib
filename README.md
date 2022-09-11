# DotnetConsumingSharedLib
An investigation to consume Linux shared library by a .NET client (console, webapi, etc)

## A. Docker.

- From base repository folder as base directory: 

### 1. Docker-compose: build library.
```
sudo docker compose -f ./docker-compose.yml -p cpp-container up --build
```
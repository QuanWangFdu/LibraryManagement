# Library Management API

## Overview

This project implements a RESTful API for a Library Management System. It provides endpoints for
managing books, authors, customers, and library branches. The API is built using ASP.NET Core
and follows RESTful principles, using JSON for data exchange.

## Features

1. **Data Model and Storage**
   - Uses the data models built in project (a) and the database.

2. **REST API Implementation**
   - Implements CRUD operations for all entities:
     - Books
     - Authors
     - Customers
     - Library Branches
   - Endpoints support:
     - Creating new entries
     - Retrieving data with specified parameters
     - Updating existing entries
     - Deleting entries

3. **JSON Payloads**
   - All API interactions use JSON for both requests and responses

4. **API Documentation**
   - Integrated Swagger UI for interactive API documentation

## API Endpoints

The following RESTful endpoints are available:

- `GET /api/{entity}` - Retrieve all items
- `GET /api/{entity}/{id}` - Retrieve a specific item
- `POST /api/{entity}` - Create a new item
- `PUT /api/{entity}/{id}` - Update an existing item
- `DELETE /api/{entity}/{id}` - Delete an item

Replace `{entity}` with `books`, `authors`, `customers`, or `libraryBranches`.

## Getting Started

1. Ensure you have .NET 8.0 SDK installed
2. Run `dotnet run` to start the application
3. Open your browser and navigate to https://localhost:5280/swagger
   - You'll see the Swagger UI, which lists all available endpoints.
   - You can test each endpoint directly from this interface.

## API Documentation

Swagger UI is integrated for easy API exploration and testing. When running the application in
development mode, navigate to `/swagger` in your web browser to access the Swagger UI.

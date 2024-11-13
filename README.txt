# Overview

The Library Management System is a comprehensive project built in three parts:

1. Basic Library Management System: An application allowing the management of books, authors, customers, and library branches.

2. Extended Version with Social Media Authentication: Adds Google and Facebook social authentication to enhance the user experience.

3. Library Management API: Implements a RESTful API to manage the library system entities programmatically, using JSON for data exchange.

This project uses ASP.NET Core for backend development, Entity Framework Core for database management, and integrates social media authentication to enhance the user experience.

# Features

1. Basic Data Management

CRUD operations for Authors, Customers, Library Branches, and Books.

Navigation through a web-based interface to manage library data.

2. Social Media Authentication

Google and Facebook authentication for easy and secure user access.

3. RESTful API

JSON-based data exchange.

Full CRUD API with documentation using Swagger UI.

# Prerequisites

.NET 8.0 SDK

Entity Framework Core NuGet package

Google and Facebook Developer accounts (for social media authentication)

# Instructions for Running the Application

1. Initial Setup

Open the Project in Your Preferred IDE

Open the project in Visual Studio Code or any other IDE of your choice.

Install Entity Framework Core Packages

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite

Install Entity Framework Tools Globally

dotnet tool install --global dotnet-ef

2. Apply Database Migrations

Run the following command to set up the initial database:

dotnet ef database update

3. Run the Application

To run the project, execute:

dotnet run

Open your browser and navigate to http://localhost:5280.

Use the navigation bar to access different sections: Authors, Customers, Library Branches, and Books.

You can create, view, edit, or delete records as needed.

4. Setting Up Social Media Authentication

Google Authentication:

Go to the Google Developer Console.

Create a new project and enable Google+ API.

Create OAuth 2.0 credentials (Client ID and Client Secret).

Facebook Authentication:

Go to Facebook for Developers.

Create a new app.

Set up Facebook Login and get the App ID and App Secret.

Set Up User Secrets

Initialize the user secrets store (if not already done):

dotnet user-secrets init

Add your social media credentials to the user secrets store:

dotnet user-secrets set "Authentication:Google:ClientId" "your-google-client-id"
dotnet user-secrets set "Authentication:Google:ClientSecret" "your-google-client-secret"
dotnet user-secrets set "Authentication:Facebook:AppId" "your-facebook-app-id"
dotnet user-secrets set "Authentication:Facebook:AppSecret" "your-facebook-app-secret"

Replace the placeholder values with your actual Google and Facebook credentials.

5. Run with Social Authentication

Re-run the database migrations:

dotnet ef database update

Run the project:

dotnet run

Open your browser and navigate to https://localhost:5280.

You can now register a new account, log in with email/password, or use Google/Facebook authentication.

6. RESTful API Implementation

The Library Management API provides endpoints for managing books, authors, customers, and library branches, allowing CRUD operations for each entity. All interactions are done using JSON for request and response.

API Endpoints

GET /api/{entity} - Retrieve all items

GET /api/{entity}/{id} - Retrieve a specific item

POST /api/{entity} - Create a new item

PUT /api/{entity}/{id} - Update an existing item

DELETE /api/{entity}/{id} - Delete an item

Replace {entity} with books, authors, customers, or libraryBranches.

7. API Documentation Using Swagger

Swagger UI is integrated for easy API exploration and testing.

To access the Swagger UI:

Run the application in development mode.

Navigate to https://localhost:5280/swagger in your web browser.

Swagger UI will list all available endpoints, allowing you to test each directly from the interface.

# Conclusion

This Library Management System provides an end-to-end solution for managing a library, featuring both a web-based management system and a RESTful API, with extended user authentication through social media. Whether you are accessing the system through a user-friendly web interface or programmatically via the API, this system offers versatility and robust functionality for managing library data.

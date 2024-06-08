# Basic ASP.NET Web API Boilerplate

Welcome to the Basic ASP.NET Web API Boilerplate! This project provides a foundational setup for building a web API using ASP.NET Core. Follow the instructions below to get your backend and frontend up and running.

## Backend Setup

### Prerequisites

Ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the repository**
2. Install necessary NuGet packages
Open the Backend directory in your terminal and run the following command:<br/>
```dotnet restore ```
## Configure your database
Update the appsettings.json file with your database connection string: 
```
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
  }
}
```
## Generate DbContext using Scaffold
Ensure your database is up and running, then run the scaffold command to generate the DbContext and entities:
```
dotnet ef dbcontext scaffold "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;" Microsoft.EntityFrameworkCore.SqlServer -o Models
```
### Installed NuGet Packages
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Design
* Microsoft.AspNetCore.Mvc.NewtonsoftJson
* Swashbuckle.AspNetCore (for API documentation)

 #### To install any additional packages, use the following command:
 ```
dotnet add package PackageName
```

## Frontend Setup
### Prerequisites
Ensure you have the following installed: 
* Node.js

### Installation
* Navigate to the ClientApp directory
* Install necessary npm packages
  ```
  npm i
  ```
* Run the application
  ```
  npm start
  ```
### Project Structure
## Backend/: Contains the ASP.NET Core Web API
* <b>Controllers/</b>: API controllers.
* <b>Models/: </b>Entity models and DbContext
* <b>Migrations/:</b> Entity framework migrations
* <b>appsettings.json:</b> Configuration file for database and other settings
* <b>Startup.cs:</b?Configuration for the application
* <b>Program.csL</b> Entry point for the application
## Frontend
* <b>ClientApp:</b> Contains the frontend application built with Angular(or it can be any of other framworks according to the preferences)

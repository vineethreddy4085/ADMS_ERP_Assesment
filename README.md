# Item Processing Application

## Overview
This is a web application developed using ASP.NET MVC where an item with a given weight can be processed to generate one or more child items. Each child item can be further processed, forming a parent-child hierarchy.

## Technologies Used
- ASP.NET MVC
- C#
- SQL Server

## Features
- Add, Update, Delete Items
- Search and List Items
- Process an item to create multiple child items
- Maintain parent-child relationship
- Display items in tree structure

## Database Setup
1. Create a database in SQL Server (e.g., ItemDB)
2. Run the SQL script provided in `/SQL/database.sql`

## Configuration
Update connection string in `Web.config`:

<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Data Source=.;Initial Catalog=ItemDB;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>

## Steps to Run
1. Clone the repository
2. Open solution in Visual Studio
3. Build the project
4. Run using IIS Express
5. Open in browser

## Notes
- Parent-child relationship is handled using `ParentItemId`
- Recursive logic is used to display hierarchy

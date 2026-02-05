# Assignment1DHall - Lakes API Microservice

### By Dana Hall - Student ID 8861127
February 5th, 2026

## Description
The Lakes microservice includes a lakes object model and relational database using SQLite. It has CRUD functionality through its LakesController.

### Schema
`
{
  "id": int,
  "name": "string",
  "location": "string",
  "volume": int
}
`

The name and location have a default value of "unspecified". Volume is meant to represent kilometres squared.

## Tech Stack
Runtime:	.NET

Language:	C#

Client:		Entity Framework Core

Database:	SQLite

## How To Run
Clone the repository

`git clone https://github.com/espeonest/Assignment1DHall`

Build project in Visual Studio

Use localhost port 7063 to interact with API once running

All routes and methods can be found in `/Controllers/LakesController.cs`

## Testing
Access the swagger page for the API once running at https://localhost:7063/swagger/index.html

### Example Data
`
{
  "id": 1,
  "name": "Lake Ontario",
  "location": "Ontario, Canada",
  "volume": 1640
}
`


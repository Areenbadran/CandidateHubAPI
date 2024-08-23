
# CandidateHubAPI

## Overview
CandidateHubAPI is a .NET Core web API for managing candidate information. It allows users to create or update candidate profiles with details.

## Features:
Add or Update Candidate Information: Single API endpoint to manage candidate profiles.

## Database: 
Uses SQL Server with Entity Framework Core for ORM.

## API Endpoint
POST --> /api/candidate/InsertCandidate\

## Request Body:
json
{
  "firstName": "Ralka",
  "lastName": "Ikdout",
  "phoneNumber": "0775827578",
  "email": "areenbadran@gmail.com",
  "callTimeInterval": "12:00 AM",
  "linkedInProfile": "",
  "gitHubProfile": "",
  "freeTextComment": "Candidate with strong skills"
}

## Response:
200 OK: Candidate information updated successfully.
201 Created: Candidate created successfully.
500 Internal Server Error: An error occurred during the operation.


## Prerequisites
.NET SDK (version 6.0 or later)
SQL Server or SQL Server Express

## Steps
Clone the Repository: git clone https://github.com/yourusername/CandidateHubAPI.git

Navigate to the Project Directory: cd CandidateHubAPI

Restore NuGet Packages: dotnet restore

Configure the Connection String: Update appsettings.json with your SQL Server connection string:
"ConnectionStrings": {
  "DefaultConnection": "Server=ServerName;Database=CandidateHubDb;Integrated Security=True;"
}

Apply Migrations: 1. "dotnet ef migrations add InitialCreate" 2. "dotnet ef database update"

Run the Application: dotnet run


## Contact:
Name: Areen Badran <br/>
Email: areenbadran9@gmail.com <br/>
GitHub: https://github.com/Areenbadran

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
json <br/>
{ <br/>
  "firstName": "Areen", <br/>
  "lastName": "Badran",<br/>
  "phoneNumber": "00962343456432", <br/>
  "email": "areenbadran@gmail.com", <br/>
  "callTimeInterval": "12:00 AM", <br/>
  "linkedInProfile": "", <br/>
  "gitHubProfile": "", <br/>
  "freeTextComment": "Candidate with strong skills" <br/>
} <br/>

## Response:
200 OK: Candidate information updated successfully. <br/>
201 Created: Candidate created successfully. <br/>
500 Internal Server Error: An error occurred during the operation. <br/>


## Prerequisites
.NET SDK version 6.0 or later <br/>
SQL Server or SQL Server Express <br/>

## Steps
Clone the Repository: git clone https://github.com/yourusername/CandidateHubAPI.git <br/>

Navigate to the Project Directory: cd CandidateHubAPI <br/>

Restore NuGet Packages: dotnet restore <br/>

Configure the Connection String: Update appsettings.json with your SQL Server connection string:
"ConnectionStrings": {
  "DefaultConnection": "Server=ServerName;Database=CandidateHubDb;Integrated Security=True;"
} <br/>

Apply Migrations: 1. "dotnet ef migrations add InitialCreate" 2. "dotnet ef database update" <br/>

Run the Application: dotnet run <br/>


## Contact:
Name: Areen Badran <br/>
Email: areenbadran9@gmail.com <br/>
GitHub: https://github.com/Areenbadran
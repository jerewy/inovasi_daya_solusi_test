# Simple Transaction API

A simple C# Web API that returns transaction data in JSON format from a SQLite database.

## Quick Start

1. Navigate to the project directory:

   ```bash
   cd SimpleApi
   ```

2. Run the application:

   ```bash
   dotnet run
   ```

3. Access the API at `http://localhost:5000/api/transactions`

## API Endpoint

### GET /api/transactions

Returns all transaction data with status information.

## What This API Does

- Uses C# with .NET 9.0
- Connects to SQLite database
- Returns JSON data matching the required format
- Includes 12 sample transaction records
- Provides status information (SUCCESS/FAILED)

## Testing

You can test the API using:

- Browser: Navigate to `http://localhost:5000/api/transactions`
- curl: `curl http://localhost:5000/api/transactions`
- Postman or any other API client

## Database

The application uses SQLite as the database. The database file (`transactions.db`) is created automatically when the application first runs, and it's populated with sample data.

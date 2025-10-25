# Simple Transaction API

A simple API that returns transaction data from a database.

## What You Need First

### Install .NET (if you don't have it)

1. **Check if you already have .NET:**

   ```bash
   dotnet --info
   ```

2. **If you see an error, install .NET:**

   ```bash
   winget install Microsoft.DotNet.SDK.9 --accept-package-agreements
   ```

3. **Check again to make sure it worked:**
   ```bash
   dotnet --info
   ```

## How to Run the API

1. **Go to the project folder:**

   ```bash
   cd SimpleApi
   ```

2. **Install the needed packages:**

   ```bash
   dotnet restore
   ```

3. **Start the API:**

   ```bash
   dotnet run
   ```

4. **Open the API test page in your browser:**
   - `https://localhost:7123/swagger`
   - If the first link shows a warning, use: `http://localhost:5123/swagger`

## What the API Does

The API has one endpoint that returns transaction data:

**GET /api/transactions**

Returns a list of transactions with their status (SUCCESS or FAILED).

## How to Test the API

### Easy Way (Recommended)

1. Start the API (see steps above)
2. Open the Swagger link in your browser
3. Click on "Transactions" → "Try it out" → "Execute"
4. You'll see the transaction data below

### With curl

```bash
curl http://localhost:5123/api/transactions
```

### Directly in Browser

Just go to: `http://localhost:5123/api/transactions`

## What You'll See

The API returns data like this:

```json
{
  "data": [
    {
      "id": 1372,
      "productID": "10001",
      "productName": "Test 1",
      "amount": "1000",
      "customerName": "abc",
      "status": 10,
      "transactionDate": "2022-07-10T11:14:52"
    }
  ],
  "status": [
    { "id": 10, "name": "SUCCESS" },
    { "id": 11, "name": "FAILED" }
  ]
}
```

## If Something Goes Wrong

### Port Already in Use

The API will automatically use a different port. Check the terminal for the correct URL.

### Certificate Warning

If you see a security warning when using the HTTPS link:

- Click "Advanced" → "Proceed to localhost"
- Or just use the HTTP link instead

### Build Errors

Try these commands:

```bash
dotnet clean
dotnet restore
dotnet build
```

## Project Structure

This project is organized into the following main folders:

- `SimpleApi/` - The ASP.NET Core API application
  - `Controllers/` - API endpoints
  - `Models/` - Data structures
  - `Data/` - Database connection
  - `transactions.db` - The database file (created automatically)
- `IT-Logic-Test/` - Contains IT logical programming test materials
  - `IT Logical Programming Test (37).docx` - A logical programming test document

## Tech Stuff

- Built with .NET 9.0
- Uses SQLite database
- Includes Swagger for easy testing
- Adding Swagger configuration for a better API experience
- Returns data in JSON format

That's it! You now have a working API with transaction data.

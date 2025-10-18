# Fix .NET API GET Route Error (Demo)

This repository demonstrates a common ASP.NET Core Web API routing issue and its fix.

## Problem (Before)
A typical mistake is forgetting to include the route parameter in the `HttpGet` attribute:
```csharp
[ApiController]
[Route("api/user")]
public class UsersController : ControllerBase
{
    // ❌ Missing route template -> /api/user/5 returns 404
    [HttpGet]
    public IActionResult GetUserById(int id) => Ok(new { id, name = "TestUser" });
}
```
This makes `/api/user/5` return **404**, even though `/api/user?id=5` works.

## Solution (After)
Add a route template and an integer constraint to follow REST conventions:
```csharp
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    // ✅ Works: GET /api/users/5
    [HttpGet("{id:int}")]
    public IActionResult GetUserById(int id) => Ok(new { id, name = $"User_{id}" });
}
```

## Tech Stack
- .NET 8, C#
- ASP.NET Core Web API
- xUnit (unit tests)
- Swagger / Postman

## How to Run (CLI)
```bash
# 1) Restore & run API
cd DotNetGetRouteFix.Api
dotnet restore
dotnet run

# API will run on https://localhost:5001 or http://localhost:5000
# Try:
curl https://localhost:5001/api/users/1 -k
```

## How to Test
```bash
cd DotNetGetRouteFix.Tests
dotnet test
```

## Suggested Loom Video Flow (2–3 min)
1. Introduce the problem (404 on `/api/users/5`)
2. Show the corrected route attribute and run the API
3. Validate the JSON response and run `dotnet test`
4. Close with a note: "I usually fix similar issues in 2–3 hours including a short test."

# Fix .NET API GET Route Error (ASP.NET Core 9 Demo)

A short, production-like demo that reproduces a common routing issue in ASP.NET Core Web API and shows how I fix it with tests and Swagger verification.

> 🎥 Demo Video (Loom): https://www.loom.com/share/REPLACE_WITH_YOUR_LINK  
> 🔗 Upwork Portfolio Entry: REPLACE_WITH_UPWORK_PORTFOLIO_URL

---

## 🚀 Overview
**Problem (Before):**  
`GET /api/users/5` returned **404** because the controller action did not include a route template with an ID parameter.

**Solution (After):**  
- Added `[HttpGet("{id:int}")]` and RESTful route pattern  
- Verified JSON response via Swagger & curl  
- Added xUnit test for the controller method

---

## 🧪 Quick Start

### Requirements
- .NET SDK **9.0** (or update the csproj to net8.0 and use SDK 8)
- macOS/Linux/Windows

### Run the API
```bash
cd DotNetGetRouteFix.Api
dotnet restore
dotnet run

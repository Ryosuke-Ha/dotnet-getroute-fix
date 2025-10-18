using Microsoft.AspNetCore.Mvc;
using DotNetGetRouteFix.Api.Models;

namespace DotNetGetRouteFix.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    // ✅ After: Route constraint ensures /api/users/5 works as expected
    [HttpGet("{id:int}")]
    public IActionResult GetUserById(int id)
    {
        var user = new User { Id = id, Name = $"User_{id}" };
        return Ok(user);
    }
}

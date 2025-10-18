using Xunit;
using Microsoft.AspNetCore.Mvc;
using DotNetGetRouteFix.Api.Controllers;
using DotNetGetRouteFix.Api.Models;

namespace DotNetGetRouteFix.Tests;

public class UsersControllerTests
{
    [Fact]
    public void GetUserById_ReturnsOk_WithExpectedUser()
    {
        // Arrange
        var controller = new UsersController();

        // Act
        var result = controller.GetUserById(5) as OkObjectResult;

        // Assert
        Assert.NotNull(result);
        Assert.Equal(200, result!.StatusCode);

        var user = Assert.IsType<User>(result.Value);
        Assert.Equal(5, user.Id);
        Assert.Equal("User_5", user.Name);
    }
}

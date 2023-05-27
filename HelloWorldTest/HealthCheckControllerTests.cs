using HelloWorld.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldTest;

public class HealthCheckControllerTests
{
    private HealthCheckController _controller;

    [SetUp]
    public void Startup()
    {
        _controller = new HealthCheckController();
    }

    [Test]
    public void GetHealth_ReturnsHealthyTrue()
    {
        // Act
        var result = _controller.GetHealth() as OkObjectResult;
        var data = result.Value as HealthCheckResponse;

        // Assert
        Assert.IsTrue(data.Healthy);
    }

}
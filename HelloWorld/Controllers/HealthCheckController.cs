using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

public class HealthCheckResponse
{
    public bool Healthy { get; set; }
}


[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class HealthCheckController : ControllerBase
{
    [HttpGet(Name = "Health")]
    public IActionResult GetHealth()
    {
        var response = new HealthCheckResponse
        {
            Healthy = true
        };
        return Ok(response);
    }
}
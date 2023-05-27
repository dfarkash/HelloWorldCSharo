using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

[ApiController]
[Route("/")]
[Produces("application/json")]
public class IndexController : ControllerBase
{
    [HttpGet(Name = "/")]
    public IActionResult Get()
    {
        
        var response = new
        {
            Status = 200,
            Messagee = "Hello World"
        };
        return Ok(response);
    }
}
using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<IndexController> _logger;

    public IndexController(ILogger<IndexController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "Hello World";
    }
}

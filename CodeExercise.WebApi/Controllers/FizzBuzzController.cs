using CodeExercise.Core;
using Microsoft.AspNetCore.Mvc;

namespace CodeExercise.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly ILogger<FizzBuzzController> _logger;
 
    public FizzBuzzController(ILogger<FizzBuzzController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Post()
    {
        _logger.LogInformation("FizzBuzzController.Post called");

        return Ok("Hello, World!");
    }
}
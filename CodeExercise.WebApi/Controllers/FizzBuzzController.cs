using CodeExercise.Core;
using CodeExercise.WebApi.DataEntities;
using Microsoft.AspNetCore.Mvc;

namespace CodeExercise.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{
    private readonly ILogger<FizzBuzzController> _logger;
    
    private readonly IOutputEngine _outputEngine;
    public FizzBuzzController(ILogger<FizzBuzzController> logger, IOutputEngine outputEngine)
    {
        _logger = logger;
        _outputEngine = outputEngine;
    }

    [HttpPost]
    public IActionResult Post(FizzBuzzParameters fizzBuzzParameters)
    {
        _logger.LogInformation("FizzBuzzController.Post called");

        if (fizzBuzzParameters == null)
        {
            _logger.LogError("Invalid input, Not present");
            return BadRequest();
        }

        if (fizzBuzzParameters.Min > fizzBuzzParameters.Max)
        {
            _logger.LogError("Invalid input, min > max");
            return BadRequest();
        }

        var result = new List<KeyValuePair<int,string>>();
        for (int i = fizzBuzzParameters.Min; i <= fizzBuzzParameters.Max; i++)
        {
            result.Add(_outputEngine.GenerateOutput(i));
        }
           
        return Ok(result);
    }
}
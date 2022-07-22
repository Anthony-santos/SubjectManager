using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller")]
public class SubjectController
{
    private readonly ILogger<WeatherForecastController> _logger;
    public SubjectController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSubjects")]
    public IEnumerable<Subject> Get()
    {
        return null;
    }
}

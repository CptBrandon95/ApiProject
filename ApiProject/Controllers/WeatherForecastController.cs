using Microsoft.AspNetCore.Mvc;
using ApiProject.NameServices;

namespace ApiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private NameService _nameService { get; set; }

    public WeatherForecastController(NameService nameService,ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _nameService = nameService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    
    }

    [HttpPost(Name = "Post weatherForecast")]
    public async Task<IActionResult> Post()
    {
        // Post Logic
        return Ok("WeatherForecast posted");
    }
    [HttpPut(Name = "Put weatherForecast")]
    public async Task<IActionResult> Put()
    {
        // Put Logic
        return Ok("WeatherForecast put");
    }
    
    
    
    [HttpDelete(Name = "Delete weatherForecast")]
    public async Task<IActionResult> Delete(int Id)
    {
        // Delete Logic
        return Ok("WeatherForecast deleted.");
    }
   
}
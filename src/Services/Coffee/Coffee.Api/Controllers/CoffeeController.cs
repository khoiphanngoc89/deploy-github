using Microsoft.AspNetCore.Mvc;

namespace Coffee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class CoffeeController : ControllerBase
{
    private static readonly string[] Coffees = new[]
    {
        "Flat White", "Long Black", "Latte", "Americano", "Cappucino"
    };

    [HttpGet]
    public IActionResult GetCoffee()
    {
        var rnd = new Random();
        return Ok(Coffees[rnd.Next(Coffees.Length)]);
    }
}
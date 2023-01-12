using Microsoft.AspNetCore.Mvc;

namespace Tea.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class TeaController : ControllerBase
{
    private static readonly string[] Teas = new[]
    {
        "Green", "Peppermint", "Earl Grey", "English Breakfast"," Camomile"
    };

    [HttpGet]
    public IActionResult GetTea()
    {
        var rnd = new Random();
        return Ok(Teas[rnd.Next(Teas.Length)]);
    }
}
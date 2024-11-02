using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [ApiController]
    public class SayHello : ControllerBase
    {
        [HttpGet("SayHello")]
        public IActionResult GetSayHello()
        {
            return Ok("Hello, World!");
        }
    }
}

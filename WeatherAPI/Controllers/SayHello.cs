using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [Route("[controller]")]
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

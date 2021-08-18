using Microsoft.AspNetCore.Mvc;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdController : ControllerBase
    {
        [HttpGet]
        [Route("duck")]
        public IActionResult Duck()
        {
            return Ok("quack");
        }

        [HttpGet]
        [Route("goose")]
        public IActionResult Goose()
        {
            return Ok("honk");
        }

        [HttpGet]
        [Route("chicken")]
        public IActionResult Chicken()
        {
            return Ok("cluck");
        }
    }
}

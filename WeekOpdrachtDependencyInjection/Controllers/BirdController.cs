using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business.Entities;

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
            Duck duck = new();
            return Ok(duck.Sound());
        }

        [HttpGet]
        [Route("goose")]
        public IActionResult Goose()
        {
            Goose goose = new();
            return Ok(goose.Sound());
        }

        [HttpGet]
        [Route("chicken")]
        public IActionResult Chicken()
        {
            Chicken chicken = new();
            return Ok(chicken.Sound());
        }
    }
}

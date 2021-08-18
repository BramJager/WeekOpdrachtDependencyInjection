using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly string a;

        public PiController(string a)
        {
            this.a = a;
        }

        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number)
        {
            var calculatePiService = new CalculatePiService();

            return Ok(new
            {
                result = (calculatePiService.Add(number))
            });
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number)
        {
            var calculatePiService = new CalculatePiService();

            return Ok(new
            {
                result = (calculatePiService.Minus(number))
            });
        }
    }
}

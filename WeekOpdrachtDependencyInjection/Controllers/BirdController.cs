using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdController : ControllerBase
    {
        private readonly IBirdSoundService birdSoundService;

        public BirdController(IBirdSoundService birdSoundService)
        {
            this.birdSoundService = birdSoundService;
        }


        [HttpGet]
        [Route("{bird}")]
        public IActionResult Bird(string bird)
        {
            return Ok(birdSoundService.ExecuteSound(bird));
        }
    }
}

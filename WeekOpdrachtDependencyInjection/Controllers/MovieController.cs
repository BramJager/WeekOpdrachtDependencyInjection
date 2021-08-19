using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly MovieService movieService;

        public MovieController(MovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
            this.movieService = new MovieService(movieRepository);
        }

        [HttpGet]
        [Route("id/{id}")]
        public IActionResult GetById(int id)
        {
            var movie = movieService.Get(id);
            return Ok(movie);
        }

        [HttpGet]
        [Route("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var movie = movieService.Get(name);
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            movieService.Save(movie);
            return Ok();
        }
    }
}

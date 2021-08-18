using System;
using System.Collections.Generic;
using System.Linq;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class MovieService
    {
        public List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Jaws", ReleaseDate = new DateTime(1975,1,1)},
            new Movie { Id = 2, Title = "Luca", ReleaseDate = new DateTime(2021,1,1)},
            new Movie { Id = 3, Title = "Kill Bill", ReleaseDate = new DateTime(2003,1,1)},
        };

        public Movie GetById(int id)
        {
            return Movies.Single(x=>x.Id == id);
        }
    }
}

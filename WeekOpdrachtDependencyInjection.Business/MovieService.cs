using System;
using System.Collections.Generic;
using System.Linq;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class MovieService
    {

        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<Movie> movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        public void Save(Movie movie) 
        {
            _movieRepository.Add(movie);
            _movieRepository.Save();
        }

        public Movie Get(int id)
        {
            return GetAll().Single(x => x.Id == id);
        }

        public Movie Get(string name)
        {
            return GetAll().Single(x => x.Title == name);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}

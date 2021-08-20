using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly MovieContext _movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            this._movieContext = movieContext;
        }

        public void Add(Movie movie)
        {
            _movieContext.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieContext.Remove(movie);
        }

        public void Delete(int id)
        {
            Movie movie = _movieContext.Movies.Find(id);
            _movieContext.Remove(movie);
        }

        public Movie Get(int id)
        {
            List<Movie> movies = new();
            movies = GetAll();
            Movie movie = movies.Single(x => x.Id == id);
            return movie;
        }

        public Movie Get(string name)
        {
            List <Movie> movies = new();
            movies = GetAll();
            Movie movie = movies.Single(x => x.Title == name);
            return movie;
        }

        public List<Movie> GetAll()
        {
            return _movieContext.Movies.ToList();
        }

        public void Update(Movie movie)
        {
            _movieContext.Entry(movie).State = EntityState.Modified;
        }

        public void Save()
        {
            _movieContext.SaveChanges();
        }
    }
}

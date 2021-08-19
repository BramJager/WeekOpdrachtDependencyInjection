using Xunit;
using Moq;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using System.Collections.Generic;

namespace WeekOpdrachtDependencyInjection.Test

{
    public class MovieRepositoryTest
    {
        private readonly Mock<IRepository<Movie>> _movieRepository;
        private readonly MovieService movieService;

        public MovieRepositoryTest()
        {
            _movieRepository = new Mock<IRepository<Movie>>();
            movieService = new MovieService(_movieRepository.Object);
        }

        [Fact]
        public void Should_AddMovie() 
        {
            //Arrange
            Movie movie = new Movie() { Title = "Jaws"};

            //Act
            movieService.Save(movie);

            //Assert
            _movieRepository.Verify(y => y.Add(movie), Times.Once);
            _movieRepository.Verify(x => x.Save(), Times.Once);
        }

        [Fact]
        public void Should_GetAll()
        {
            //Arrange

            //Act
            movieService.GetAll();

            //Assert
            _movieRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Fact]
        public void Should_GetMovieById()
        {
            //Arrange
            _movieRepository.Setup(t => t.GetAll())
                .Returns(new List<Movie> 
                       { new Movie { Id = 1, Title = "Jaws" }, 
                         new Movie { Id = 2, Title = "Vertigo" } });

            int id = 1;

            //Act
            Movie movie = movieService.Get(id);

            //Assert
            Assert.Equal(id, movie.Id);
        }

        [Fact]
        public void Should_GetMovieByName()
        {
            //Arrange
            _movieRepository.Setup(t => t.GetAll())
                .Returns(new List<Movie>
                       { new Movie { Id = 1, Title = "Jaws" },
                         new Movie { Id = 2, Title = "Vertigo" } });

            string name = "Vertigo";

            //Act
            Movie movie = movieService.Get(name);

            //Assert
            Assert.Equal(name, movie.Title);
        }
    }
}

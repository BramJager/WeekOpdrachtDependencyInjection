using Microsoft.EntityFrameworkCore;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}

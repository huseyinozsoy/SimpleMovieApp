using Microsoft.EntityFrameworkCore;

namespace SimpleMovieApp.Models
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Movie.db");
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
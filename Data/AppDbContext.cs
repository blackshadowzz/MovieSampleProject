using Microsoft.EntityFrameworkCore;
using MovieSampleProject.Models;

namespace MovieSampleProject.Data
{
    public class AppDbContext:DbContext
    {
        //Connection To database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MovieSampleDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        //Add DbSet
        public DbSet<Movie> Movies { get; set; }
    }
}

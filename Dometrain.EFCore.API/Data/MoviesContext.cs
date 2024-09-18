using Dometrain.EFCore.API.Models;
using Microsoft.EntityFrameworkCore;

public class MoviesContext : DbContext
{
    //protected Set<> Method isnt nullable
    public DbSet<Movie> Movies => Set<Movie>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=MoviesDB;User Id=sa;Password=;TrustServerCertificate=True");
        optionsBuilder.LogTo(Console.WriteLine);
        base.OnConfiguring(optionsBuilder);
    }


}
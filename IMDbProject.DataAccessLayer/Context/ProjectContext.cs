using IMDbProject.EntityLayer.Entites.Concrete;
using System.Data.Entity;

namespace IMDbProject.DataAccessLayer.Context
{
    public class ProjectContext:DbContext //EntityFreamwork sayesinde DbContext nesnemizi tanımladık.
    {
        public ProjectContext() //Bağlantı yolu constructer methodunun içine yazıldı.
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-9CA7T86\MSQL;Database=IMDbProject;Integrated Security=True;";
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AssignedMovietoDirector> AssignedMovietoDirectors { get; set; }
        public DbSet<AssignedMovietoGenre> AssignedMovietoGenres { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}



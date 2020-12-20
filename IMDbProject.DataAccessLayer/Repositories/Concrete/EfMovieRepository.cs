using IMDbProject.DataAccessLayer.Repositories.Interfaces;
using IMDbProject.EntityLayer.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMDbProject.DataAccessLayer.Repositories.Concrete
{
    public class EfMovieRepository : EfBaseRepository, IMovieRepository,IBaseRepository
    {
        public void CreateMovie(string MovieName, string Content, string ImageUrl, DateTime ProductionDate, string MovieReview)
        {
            Movie movie = new Movie();
            movie.MovieName = MovieName;
            movie.Content = Content;
            movie.ImageUrl = ImageUrl;
            movie.ProductionDate = ProductionDate;
            movie.MovieReview = MovieReview;
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is System.Windows.Forms.TextBox || item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<Movie> GetMovie()
        {
            return db.Movies.Where(x => x.Status != EntityLayer.Enums.Status.Passive).ToList();
        }

        public void ModifiedMovie(int id, string Moviename, string Content, string ImageUrl, DateTime ProductionDate, string MovieReview)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x=> x.Id == id);
            movie.MovieName = Moviename;
            movie.Content = Content;
            movie.ImageUrl = ImageUrl;
            movie.ProductionDate = ProductionDate;
            movie.MovieReview = MovieReview;
            movie.ModifiedDate = DateTime.Now;
            movie.Status = EntityLayer.Enums.Status.Modefied;
            db.SaveChanges();
        }

        public void PassiveMovie(int id)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.Status = EntityLayer.Enums.Status.Passive;
            movie.PassivedDate = DateTime.Now;
            db.SaveChanges();
        }

       

        public List<Movie> GetFindMovieName(string MovieName)
        {
            return db.Movies.Where(x => x.MovieName.ToLower().Contains(MovieName.ToLower()) && x.Status != EntityLayer.Enums.Status.Passive).ToList();
        }
    }
}

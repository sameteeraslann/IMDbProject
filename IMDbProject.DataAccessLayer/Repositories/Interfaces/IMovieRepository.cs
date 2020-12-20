using IMDbProject.DataAccessLayer.Repositories.Concrete;
using IMDbProject.EntityLayer.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbProject.DataAccessLayer.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        void CreateMovie(string MovieName,string Content,string ImageUrl,DateTime ProductionDate,string MovieReview);
        void ModifiedMovie(int id, string Moviename, string Content, string ImageUrl, DateTime ProductionDate, string MovieReview);
        void PassiveMovie(int id);
       

        List<Movie> GetMovie();
        List<Movie> GetFindMovieName(string MovieName);
    }
}

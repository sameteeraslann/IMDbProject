using IMDbProject.DataAccessLayer.Repositories.Interfaces;
using IMDbProject.EntityLayer.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbProject.DataAccessLayer.Repositories.Concrete
{
    public class EfGenreRepository : EfBaseRepository, IGenreRepository, IBaseRepository
    {
        public void CreateGenre(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Lütfen Bilgi Girin");
            }
            else
            {
                Genre genre = new Genre
                {
                    GenreName = name,
                    CreateDate = DateTime.Now,
                };
                db.Genres.Add(genre);
                db.SaveChanges();
            }
            
        }

        public void DeleteGenre(int id)
        {
            Genre genre = new Genre();
            genre = db.Genres.FirstOrDefault(x=> x.Id == id);
            if (genre == null)
            {
                MessageBox.Show("Burası Boş");
            }
            else
            {
                genre.PassivedDate = DateTime.Now;
                genre.Status = EntityLayer.Enums.Status.Passive;
                db.SaveChanges();
            }
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void FindById(int id, TextBox textBox)
        {
            Genre genre = new Genre();
            genre = db.Genres.FirstOrDefault(x=> x.Id == id);
            textBox.Text = genre.GenreName;
        }

        public List<Genre> FindbyName(string name)
        {
            return db.Genres.Where(x => x.GenreName.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public List<Genre> GetGenre()
        {
            return db.Genres.Where(x => x.Status != EntityLayer.Enums.Status.Passive).ToList();
        }

        public void UpdateGenre(int id, string name)
        {
            Genre genre = new Genre();
           
            genre = db.Genres.FirstOrDefault(x=> x.Id == id);
            genre.GenreName = name;
            genre.ModifiedDate = DateTime.Now;
            genre.Status = EntityLayer.Enums.Status.Modefied;
            db.SaveChanges();
           
        }
    }
}

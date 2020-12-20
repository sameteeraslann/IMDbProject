using IMDbProject.EntityLayer.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbProject.DataAccessLayer.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        void CreateGenre(string name);
        void UpdateGenre(int id, string name);
        void DeleteGenre(int id);
        void FindById(int id, TextBox textBox);

        List<Genre> GetGenre();
        List<Genre> FindbyName(string name);
        List<Genre> GetAll();


    }
}

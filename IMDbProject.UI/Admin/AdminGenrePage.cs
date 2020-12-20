using IMDbProject.DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbProject.UI.Admin
{
    public partial class AdminGenrePage : Form
    {
        public AdminGenrePage()
        {
            InitializeComponent();
        }
        EfGenreRepository efGenre = new EfGenreRepository();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            efGenre.CreateGenre(txtGenreName.Text);
            dataGridView1.DataSource = efGenre.GetGenre();
            efGenre.Eraser(grpAddGenre);
        }

        private void AdminGenrePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenre.GetGenre();
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            efGenre.FindById(int.Parse(txtUpdateFindbyId.Text),txtUpdateGenreName);
            dataGridView1.DataSource = efGenre.GetGenre();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            efGenre.UpdateGenre(int.Parse(txtUpdateFindbyId.Text),txtUpdateGenreName.Text);
            dataGridView1.DataSource = efGenre.GetGenre();
            efGenre.Eraser(grpUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            efGenre.DeleteGenre(int.Parse(txtDelete.Text));
            dataGridView1.DataSource = efGenre.GetGenre();
            efGenre.Eraser(grpDelete);
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            efGenre.FindbyName(txtFindByName.Text);
            dataGridView1.DataSource = efGenre.GetGenre();
            efGenre.Eraser(grpFindById);
        }

        private void btnListofGenre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenre.GetAll();
        }
    }
}

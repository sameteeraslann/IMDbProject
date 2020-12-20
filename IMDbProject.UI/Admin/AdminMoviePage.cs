using IMDbProject.DataAccessLayer.Repositories.Concrete;
using System;
using System.Windows.Forms;

namespace IMDbProject.UI.Admin
{
    public partial class AdminMoviePage : Form
    {
        public AdminMoviePage()
        {
            InitializeComponent();
        }
        EfMovieRepository efMovie = new EfMovieRepository();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            efMovie.CreateMovie(
                txtMovieName.Text,
                txtContent.Text,
                txtImageUrl.Text,
                DateTime.Parse(dateTimePicker1.Text),
                txtMovieReview.Text
                );
            dataGridView1.DataSource = efMovie.GetMovie();
            efMovie.Eraser(grpMovieAdd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            efMovie.PassiveMovie(
                int.Parse( lblFindById.Text)
                );
            dataGridView1.DataSource = efMovie.GetMovie();
            efMovie.Eraser(grpMovieAdd);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            efMovie.ModifiedMovie(
                int.Parse(lblFindById.Text),
                txtMovieName.Text,
                txtContent.Text,
                txtImageUrl.Text,
                DateTime.Parse(dateTimePicker1.Text),
                txtMovieReview.Text
                );
            dataGridView1.DataSource = efMovie.GetMovie();
            efMovie.Eraser(grpMovieAdd);
        }

        private void btnListOfMovies_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efMovie.GetMovie();
        }

        private void AdminMoviePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efMovie.GetMovie();
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efMovie.GetFindMovieName(txtMovieName.Text);
        }

        int id;
        void KayitSatiriSec()
        {
            // Burada datagridview de seçtiğimiz satırı Textboxlara dolduracak.
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            lblFindById.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtMovieName.Text = dataGridView1.CurrentRow.Cells["MovieName"].Value.ToString();
            txtContent.Text = dataGridView1.CurrentRow.Cells["Content"].Value.ToString();
            txtImageUrl.Text = dataGridView1.CurrentRow.Cells["ImageUrl"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ProductionDate"].Value.ToString();
            txtMovieReview.Text = dataGridView1.CurrentRow.Cells["MovieReview"].Value.ToString();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KayitSatiriSec();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGenrePage adminGenre = new AdminGenrePage();
            adminGenre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoviePage moviePage = new MoviePage();
            moviePage.Show();
            this.Hide();
        }
    }
}

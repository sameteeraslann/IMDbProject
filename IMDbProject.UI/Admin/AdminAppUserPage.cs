using IMDbProject.DataAccessLayer.Repositories.Concrete;
using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbProject.UI
{
    public partial class AdminAppUserPage : Form
    {
        public AdminAppUserPage()
        {
            InitializeComponent();
        }

        EfAppUserRepository efAppUser = new EfAppUserRepository();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            efAppUser.CreateAppUser(
                txtFirstName.Text,
                txtLastName.Text,
                txtUserName.Text,
                txtPassword.Text,
                (Role)Enum.Parse(typeof(Role),cmbRol.Text)
                );
            dataGridView1.DataSource = efAppUser.GetUser();
            efAppUser.Eraser(grpAddUser);
                
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            efAppUser.PassiveAppUser(txtFirstName.Text);
            dataGridView1.DataSource = efAppUser.GetUser();
            efAppUser.Eraser(grpAddUser);
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efAppUser.CallbyName(txtFirstName.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            efAppUser.ModifiedAppUser(
                txtFirstName.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtUserName.Text,
                txtPassword.Text,
                (Role)Enum.Parse(typeof(Role),cmbRol.Text)
                );
            dataGridView1.DataSource = efAppUser.GetUser();
            efAppUser.Eraser(grpAddUser);
        }

        private void AdminAppUserPage_Load(object sender, EventArgs e)
        {
            efAppUser.Eraser(grpAddUser);
            efAppUser.GetRole(cmbRol);
            dataGridView1.DataSource = efAppUser.GetUser();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EfAppUserRepository.KayitSatiriSec(txtFirstName, txtLastName, txtUserName, txtPassword, dataGridView1);
        }
    }
}

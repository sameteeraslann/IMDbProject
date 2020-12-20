using IMDbProject.DataAccessLayer.Repositories.Interfaces;
using IMDbProject.EntityLayer.Entites.Concrete;
using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMDbProject.DataAccessLayer.Repositories.Concrete
{
    public class EfAppUserRepository :EfBaseRepository, IBaseRepository, IAppUserRepository
    {
        public List<AppUser> CallbyName(string fullname)
        {
            // FirstName üzerinden arama yaptığımızda girilen harfleri hem küçük karakterlere çevirir hemde girilen karater kadar arama yapar ve listeler.
            return db.AppUsers.Where(x => x.FirstName.ToLower().Contains(fullname.ToLower()) && x.Status != Status.Passive).ToList();
        }
        static int id;
        public static void KayitSatiriSec(TextBox txtFindById, TextBox txtfirstname, TextBox txtlastname, TextBox txtusername,TextBox txtpassword,DataGridView dataGridView)
        {
            // Burada datagridview de seçtiğimiz satırı Textboxlara dolduracak.

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
            txtFindById.Text = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
            txtfirstname.Text = dataGridView.CurrentRow.Cells["FirstName"].Value.ToString();
            txtlastname.Text = dataGridView.CurrentRow.Cells["LastName"].Value.ToString();
            txtusername.Text = dataGridView.CurrentRow.Cells["UserName"].Value.ToString();
            txtpassword.Text = dataGridView.CurrentRow.Cells["Password"].Value.ToString();
        }

        public void CreateAppUser(string firstName, string lastName, string userName, string password, Role role)
        {
            
            AppUser appUser = new AppUser();
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.UserName = userName;
            appUser.Password = password;
            appUser.Role = role;
            appUser.CreateDate = DateTime.Now;
            db.AppUsers.Add(appUser);
            db.SaveChanges();

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

       
        //public void FindByName(string fullname)
        //{

        //    return db.AppUsers.Where(x => x.FullName.ToLower().Contains(fullname.ToLower())).ToList();
        //    //EfAppUserRepository efAppUser = new EfAppUserRepository();

        //    //foreach (var item in db.AppUsers)
        //    //{
        //    //    for (int i = 0; i < item.Id; i++)
        //    //    {
        //    //        if (item.Status == Status.Active || item.Status == Status.Modefied)
        //    //        {
        //    //            if (item.FirstName == txtFirstName.Text)
        //    //            {
        //    //                txtFirstName.Text = item.FirstName;
        //    //                txtLastName.Text = item.LastName;
        //    //                txtUserName.Text = item.UserName;
        //    //                txtPassword.Text = item.Password;
        //    //                dataGridView.DataSource = efAppUser.GetUser();
        //    //                break;
        //    //            }
        //    //        }
        //    //        break;
        //    //    }
        //    //}

        //}

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public void GetRole(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBox.SelectedIndex = 1;
        }

        public List<AppUser> GetUser()
        {
            return db.AppUsers.Where(x => x.Status != Status.Passive).ToList();
        }

        public void ModifiedAppUser(int id, string firstName, string lastName, string userName, string password, Role role)
        {
            AppUser appUser = new AppUser();
            appUser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.UserName = userName;
            appUser.Password = password;
            appUser.Role = role;
            appUser.ModifiedDate = DateTime.Now;
            appUser.Status = Status.Modefied;
            db.SaveChanges();
        }

        public void PassiveAppUser(int id)
        {
            AppUser appUser = new AppUser();
            appUser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appUser.PassivedDate = DateTime.Now;
            appUser.Status = Status.Passive;
            db.SaveChanges();
        }

        public void Bosmu(GroupBox groupBox, Label lblFirst, Label lblLast, Label lblUser, Label lblPassword)
        {
            string message = "Lütfen boş alanları doldurun";
            foreach (Control item in groupBox.Controls)
            {
                if (String.IsNullOrEmpty(item.Text))
                {
                  
                }
            }
        }
    }
}

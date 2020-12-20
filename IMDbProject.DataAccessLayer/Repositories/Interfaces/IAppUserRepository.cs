using IMDbProject.EntityLayer.Entites.Concrete;
using IMDbProject.EntityLayer.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMDbProject.DataAccessLayer.Repositories.Interfaces
{
    public interface IAppUserRepository
    {
        void CreateAppUser(string firstName, string lastName, string userName, string password, Role role);
        void ModifiedAppUser(int id, string firstName, string lastName, string userName, string password, Role role);
        void PassiveAppUser(int id);
        void Bosmu(GroupBox groupBox,Label lblFirst,Label lblLast,Label lblUser,Label lblPassword);
       
        void GetRole(ComboBox comboBox); 
       

        List<AppUser> CallbyName(string fullname);
        List<AppUser> GetAll();
        List<AppUser> GetUser();
        
    }
}

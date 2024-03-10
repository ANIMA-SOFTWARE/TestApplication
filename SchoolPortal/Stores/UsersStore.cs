
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Transactions;
using SchoolPortal.Models;
using SchoolPortal.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolPortal.Stores
{
   public class UsersStore : BaseStore, IStore
    {
        public UsersStore() {

        }
        public void Create(BaseModel model)
        {
           User u = (User)model;
            
            string sql = "INSERT INTO Users (Name,Email,Password,Username,RoleId) VALUES (@Name,@Email,@Password,@Username,@RoleId)";
            object[] parameters = { new { u.Name, u.Email, u.Password, u.Username, u.RoleId } };
            database.Execute(sql, parameters);
        }

        public void Delete(BaseModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(BaseModel model)
        {
            throw new NotImplementedException();
        }
    }
}

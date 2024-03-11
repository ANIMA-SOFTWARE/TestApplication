using SchoolPortal.Models;
using SchoolPortal.Storage;

namespace SchoolPortal.Stores
{
   public class UsersStore
    {
        private readonly IDatabase database;
        public UsersStore(SchoolPortalDatabase schoolPortalDatabase) {
            database = schoolPortalDatabase.database ?? throw new Exception("Failed to get database"); 
        }
        public void Create(User model)
        {
           User u = model;

            string sql = "INSERT INTO Users (Name,Email,Password,Username,RoleId) VALUES (@Name,@Email,@Password,@Username,@RoleId)";
            object[] parameters = { new { u.Name, u.Email, u.Password, u.Username, u.RoleId } };
            database.Execute(sql, parameters);
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetAll()
        {
            string sql = "SELECT Id,Name,Email,Password,Username,RoleId FROM Users";
            return database.Query<User>(sql);
        }
    }
}

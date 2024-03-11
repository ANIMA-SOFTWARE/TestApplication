using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string Username { get; set; } 
        public int RoleId { get; set; }

        public User(int Id, string Name, string Email, string Password, string Username, int RoleId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Username = Username;
            this.RoleId = RoleId;
        }

        public User(string Name, string Email, string Password, string Username, int RoleId)
        {
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Username = Username;
            this.RoleId = RoleId;
        }


    }
}

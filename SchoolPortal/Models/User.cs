using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class User(string _Name) : BaseModel
    {
        public string Name { get; set; } = _Name;
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Username { get; set; } = "";
        public int RoleId { get; set; } = 0;

    }
}

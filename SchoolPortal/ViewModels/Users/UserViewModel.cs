using CommunityToolkit.Mvvm.ComponentModel;
using SchoolPortal.Models;

namespace SchoolPortal.ViewModels
{
    public partial class UserViewModel(User user) : ObservableObject
    {
        private readonly User _user = user;
        public string Id => _user.Id;
        public string Name => _user.Name;
        public string Email => _user.Email;
        public string Password => _user.Password;
        public string Role => _user.Role;
    }
}

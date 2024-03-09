using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SchoolPortal.ViewModels
{
  public partial class AddUserViewModel : ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string username;
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public string role;

        public AddUserViewModel()
        {
            Name = string.Empty;
            Email = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }

        [RelayCommand]
        public void Add(string name, string email, string username, string password, string role)
        {
            
        }

    }
}

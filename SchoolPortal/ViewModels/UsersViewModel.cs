using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Models;

namespace SchoolPortal.ViewModels
{
    public partial class UsersViewModel : ObservableObject
    {
        public UsersViewModel()
        {
            Users = new ObservableCollection<User>();
        }

        [ObservableProperty]
        ObservableCollection<User> users;

        [ObservableProperty]
        string name = "";

        [RelayCommand]
        void Add()
        {
            Users.Add(new User(Name));
            Name = "";
        }

    }
}

using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Primitives;
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
        string name;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return;
           
            Users.Add(new User(Name));
            Name = string.Empty;
        }

        [RelayCommand]
        void Delete(string Name)
        {
            if (Users.Where(user => user.Name == Name).Any())
            {
                Users.Remove(Users.Where(u => u.Name == Name).First());
            }
         
        }

    }
}

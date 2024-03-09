using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Models;

namespace SchoolPortal.ViewModels
{
    public partial class UsersListViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<UserViewModel> users;

        public UsersListViewModel()
        {
            Users = new ObservableCollection<UserViewModel>();
        }

        [RelayCommand(CanExecute = nameof(CanAdd())]
        void Add(string Name, string Email, string Username, string Password, string Role)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return;

            User user = new(Name);

            Users.Add(new UserViewModel(user));

        }

        void CanAdd()
        {
            return string.IsNullOrEmpty(Name) || string.IsNullOrEmpty()
        }

   

        [RelayCommand]
        void Delete(string Id)
        {
            if (Users.Where(user => user.Id == Id).Any())
            {
                Users.Remove(Users.Where(u => u.Id == Id).First());
            }

        }

    }
}

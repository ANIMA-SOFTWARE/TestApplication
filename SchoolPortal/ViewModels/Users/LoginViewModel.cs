using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Helpers;
using SchoolPortal.Models;
using SchoolPortal.Stores;

namespace SchoolPortal.ViewModels
{
  public partial class LoginViewModel : ObservableObject
    {
        private readonly UsersStore Store;

        [ObservableProperty]
        string username = "";

        [ObservableProperty]
        string password = "";

        public LoginViewModel()
        {
            Store = ServiceHelper.GetService<UsersStore>();
        }

        [RelayCommand]
        async Task Login()
        {
           List<User> Users = (List<User>)Store.GetAll();

            bool loginSuccess = false;
            foreach (var User in Users)
            {   
             if(User.Username == this.Username && User.Password == this.Password)
                {
                    loginSuccess = true;
                    break;
                }
            };

            if (loginSuccess) { 
                await Shell.Current.DisplayAlert("Success!", "Login Successful", "Ok"); 
            } else {
                await Shell.Current.DisplayAlert("Failed!", "Login Failed", "Ok");
            }
        }

    }
}

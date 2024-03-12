using System.Collections.ObjectModel;
using System.Collections.Specialized;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Helpers;
using SchoolPortal.Models;
using SchoolPortal.Pages;
using SchoolPortal.Stores;

namespace SchoolPortal.ViewModels
{
    public partial class UsersListViewModel : ObservableObject
    {

        [ObservableProperty]
        IEnumerable<User> users;

        private readonly UsersStore store;

        public UsersListViewModel()
        {

            store = ServiceHelper.GetService<UsersStore>();
            Users = (List<User>)store.GetAll();

        }

       [RelayCommand]
        async Task GoToCreateUserPage()
       {
          await Shell.Current.GoToAsync(nameof(CreateUserPage));
        }

      

        [RelayCommand]
         void Delete(int Id)
        {
            //Delete from db
            store.Delete(Id);
            //Delete from collection
            Users = Users.Where(x => x.Id != Id).ToList();
        }

        private void GetAll(object? sender, NotifyCollectionChangedEventArgs e)
        {
            Users = (List<User>)store.GetAll();
        }     

    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Helpers;
using SchoolPortal.Models;
using SchoolPortal.Stores;

namespace SchoolPortal.ViewModels
{
    public partial class UserViewModel : ObservableObject
    {
        private readonly UsersStore Store;

        [NotifyCanExecuteChangedFor(nameof(CreateCommand))]
        [ObservableProperty]
        string name = "";
        
        [NotifyCanExecuteChangedFor(nameof(CreateCommand))]
        [ObservableProperty]
        string email = "";
        
        [NotifyCanExecuteChangedFor(nameof(CreateCommand))]
        [ObservableProperty]
        string password = "";
        
        [NotifyCanExecuteChangedFor(nameof(CreateCommand))]
        [ObservableProperty]
        string username = "";
        
        [NotifyCanExecuteChangedFor(nameof(CreateCommand))]
        [ObservableProperty]
        int roleId = -1;
        public UserViewModel() {
            Store = ServiceHelper.GetService<UsersStore>();
        }

        [RelayCommand(CanExecute = nameof(CanCreate))]
        void Create()
        {
           
            Store.Create(new User(Name, Email, Password, Username, RoleId));
            
            Name = "";
            Email = "";
            Password = "";
            Username = "";
            RoleId = -1;
        }

        bool CanCreate()
        {
        return Name != "" && Email != "" && Password != "" && Username != "" & RoleId != -1;
        }
    }
}

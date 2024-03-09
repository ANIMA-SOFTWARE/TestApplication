

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolPortal.Pages;

namespace SchoolPortal.ViewModels
{
  public partial class MainViewModel : ObservableObject
    {

        [RelayCommand]
        async Task GoToUsersPage()
        {
            await Shell.Current.GoToAsync(nameof(UsersListPage));
        }

    }
}

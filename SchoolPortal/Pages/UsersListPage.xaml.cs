using SchoolPortal.Helpers;
using SchoolPortal.ViewModels;

namespace SchoolPortal.Pages;
public partial class UsersListPage : ContentPage
{
	public UsersListPage(UsersListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}
}
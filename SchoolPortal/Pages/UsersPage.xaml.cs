using SchoolPortal.ViewModels;

namespace SchoolPortal.Pages;

public partial class UsersPage : ContentPage
{
	public UsersPage(UsersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}
}
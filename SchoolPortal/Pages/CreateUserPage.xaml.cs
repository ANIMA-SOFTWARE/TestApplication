

using SchoolPortal.Helpers;
using SchoolPortal.ViewModels;

namespace SchoolPortal.Pages;
public partial class CreateUserPage : ContentPage
{
	public CreateUserPage(UserViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}
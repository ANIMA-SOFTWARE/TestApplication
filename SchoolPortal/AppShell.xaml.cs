using SchoolPortal.Pages;

namespace SchoolPortal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routes
            Routing.RegisterRoute(nameof(UsersListPage), typeof(UsersListPage));
            Routing.RegisterRoute(nameof(CreateUserPage), typeof(CreateUserPage));
        }
    }
}

using SchoolPortal.Pages;

namespace SchoolPortal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(UsersListPage), typeof(UsersListPage));
        }
    }
}

using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using SchoolPortal.ViewModels;
using SchoolPortal.Pages;
using SchoolPortal.Stores;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace SchoolPortal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()

            //Fonts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //Services
  
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<UsersListViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<UsersListPage>();

            builder.Services.AddSingleton<UsersStore>();

            //Config builder


            //Database context
            var sqlServerConnectionString = configuration.GetConnectionString("DefaultConnection") ?? ""; 
            builder.Services.AddSingleton<SqlConnection>(connection => sqlServerConnectionString);




#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

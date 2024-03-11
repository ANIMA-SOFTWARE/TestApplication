using Microsoft.Extensions.Logging;
using SchoolPortal.ViewModels;
using SchoolPortal.Pages;
using SchoolPortal.Stores;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using SchoolPortal.Storage;
using System.Reflection;

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


            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
       
            builder.Services.AddTransient<UsersListPage>();
            builder.Services.AddTransient<UsersListViewModel>();

            builder.Services.AddTransient<CreateUserPage>();
            builder.Services.AddTransient<UserViewModel>();

            builder.Services.AddSingleton<UsersStore>();

            //Config builder

            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("SchoolPortal.appsettings.json");

            var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();


            builder.Configuration.AddConfiguration(config);

            var connectionString = config.GetSection("DefaultConnection").Value;
            builder.Services.AddSingleton<SchoolPortalDatabase>();






#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

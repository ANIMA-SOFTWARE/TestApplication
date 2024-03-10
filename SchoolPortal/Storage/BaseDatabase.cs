using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SchoolPortal.Storage;
public class BaseDatabase
{

    public string connectionString;

    public BaseDatabase() {

        var configBuilder = new ConfigurationBuilder()
        .AddJsonFile($"appsettings.json", true, true);

        IConfiguration configuration = configBuilder.Build();

        connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
    }
}


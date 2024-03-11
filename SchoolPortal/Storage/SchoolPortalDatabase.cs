using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SchoolPortal.Storage
{
    public class SchoolPortalDatabase
    {
        private IConfiguration config;
        public IDatabase database;

        public SchoolPortalDatabase(IConfiguration config) {
            this.config = config;
            this.database = GetDatabase() ?? throw new Exception("No database found");
        }



        public IDatabase? GetDatabase()
        {
            var databaseType = config.GetSection("DatabaseType").Value;
            var connectionString = config.GetSection("DefaultConnection").Value;

            IDatabase? database = null;

            switch (databaseType)
            {

                //Add new types here

                case "SQLServer":
                    database = new SQLServer(connectionString);
                    break;


                default:
                    throw new Exception("Database type specified in config file has not been implemented");
            }

            return database;
        }

    }
}

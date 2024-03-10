
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SchoolPortal.Models;
using SchoolPortal.Storage;

namespace SchoolPortal.Stores
{
   public class BaseStore
    {
       public IDatabase database = new SQLServer();

    }
}

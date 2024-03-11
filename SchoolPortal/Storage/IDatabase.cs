using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Models;
using static Dapper.SqlMapper;

namespace SchoolPortal.Storage
{
   public interface IDatabase
    {
        DbConnection NewConnection();
        IEnumerable<T> Query<T>(string sql, object? param = null);
        IEnumerable<T> QueryAsync<T>(string sql, object? param = null);
        T QuerySingle<T>(string sql);
        T QuerySingleOrDefault<T>(string sql);
        T QueryFirst<T>(string sql);
        T QueryFirstOrDefault<T>(string sql);
        GridReader QueryMultiple(string sql, object? param = null);
        GridReader QueryMultipleAsync(string sql, object? param = null);
        int Execute(string sql, object? param = null);
        int ExecuteAsync(string sql, object? param = null);

    }
}

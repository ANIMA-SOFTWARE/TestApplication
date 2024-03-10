using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Models;
using static Dapper.SqlMapper;

namespace SchoolPortal.Storage
{
   public interface IDatabase
    {
        IEnumerable<BaseModel> Query<BaseModel>(string sql, object? param = null);
        IEnumerable<BaseModel> QueryAsync<BaseModel>(string sql, object? param = null);
        BaseModel QuerySingle<BaseModel>(string sql);
        BaseModel QuerySingleOrDefault<BaseModel>(string sql);
        BaseModel QueryFirst<BaseModel>(string sql);
        BaseModel QueryFirstOrDefault<BaseModel>(string sql);
        GridReader QueryMultiple(string sql, object? param = null);
        GridReader QueryMultipleAsync(string sql, object? param = null);
        int Execute(string sql, object? param = null);
        int ExecuteAsync(string sql, object? param = null);

    }
}

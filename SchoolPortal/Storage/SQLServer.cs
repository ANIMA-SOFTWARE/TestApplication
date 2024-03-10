using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using SchoolPortal.Models;

namespace SchoolPortal.Storage;

    public class SQLServer : BaseDatabase, IDatabase
{
        private readonly SqlConnection connection;


        public SQLServer() { 
    
        connection = new SqlConnection(connectionString);
         }

    public int Execute(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public int ExecuteAsync(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BaseModel> Query<BaseModel>(string sql, object? param = null)
    {
       return connection.Query<BaseModel>(sql, param);
    }

    public IEnumerable<BaseModel> QueryAsync<BaseModel>(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public BaseModel QueryFirst<BaseModel>(string sql)
    {
        throw new NotImplementedException();
    }

    public BaseModel QueryFirstOrDefault<BaseModel>(string sql)
    {
        throw new NotImplementedException();
    }

    public SqlMapper.GridReader QueryMultiple(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public SqlMapper.GridReader QueryMultipleAsync(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public BaseModel QuerySingle<BaseModel>(string sql)
    {
        throw new NotImplementedException();
    }

    public BaseModel QuerySingleOrDefault<BaseModel>(string sql)
    {
        throw new NotImplementedException();
    }
}


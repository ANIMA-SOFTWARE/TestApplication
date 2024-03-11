using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SchoolPortal.Models;

namespace SchoolPortal.Storage;

    public class SQLServer : IDatabase
{
    private readonly string connectionString;
    public SQLServer(string connectionString) {
        this.connectionString = connectionString;
    }

    public DbConnection NewConnection()
    {
        return new SqlConnection(connectionString);
    }

    public int Execute(string sql, object? param = null)
    {
       using var conn = NewConnection();
        return conn.Execute(sql, param);
    }

    public int ExecuteAsync(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

   
    public IEnumerable<T> Query<T>(string sql, object? param = null)
    {
        using var conn = NewConnection();
        return conn.Query<T>(sql,param);

    }

    public IEnumerable<T> QueryAsync<T>(string sql, object? param = null)
    {
        throw new NotImplementedException();
    }

    public T QueryFirst<T>(string sql)
    {
        throw new NotImplementedException();
    }

    public T QueryFirstOrDefault<T>(string sql)
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

    public T QuerySingle<T>(string sql)
    {
        throw new NotImplementedException();
    }

    public T QuerySingleOrDefault<T>(string sql)
    {
        throw new NotImplementedException();
    }
}


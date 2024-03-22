// DapperUnitOfWork.cs

using System.Data;
using Scan_Product_TTTQ.Domain.Abstractions;
using MySql.Data.MySqlClient;

namespace Scan_Product_TTTQ.Application.Common.Context;

public class DapperUnitOfWork : IUnitOfWork
{
    private readonly IDbConnection _connection;
    private IDbTransaction _transaction;

    public DapperUnitOfWork(string connectionString)
    {
        _connection = new MySqlConnection(connectionString);
        _connection.Open();
        _transaction = _connection.BeginTransaction();
    }

    public int Commit()
    {
        try
        {
            _transaction.Commit();
            return 1; // Successfully committed
        }
        catch
        {
            _transaction.Rollback();
            return 0; // Indicates a failure
        }
        finally
        {
            _transaction?.Dispose();
            _transaction = _connection.BeginTransaction();
        }
    }

    public void Dispose()
    {
        _transaction?.Commit();
        _connection?.Close();
    }
}
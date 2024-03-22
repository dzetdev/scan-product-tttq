using System.Data;
using Scan_Product_TTTQ.Infrastructure.Data;

namespace Scan_Product_TTTQ.Infrastructure.Repositories;

public class BaseRepository
{
    protected readonly IDbConnection _connection;

    public BaseRepository(MySqlConnectionFactory connectionFactory)
    {
        _connection = connectionFactory.CreateConnection();
        _connection.Open();
    }
}
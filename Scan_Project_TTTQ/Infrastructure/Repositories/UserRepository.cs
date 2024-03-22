using Dapper;
using Scan_Product_TTTQ.Application.Users;
using Scan_Product_TTTQ.Domain.Entities;
using Scan_Product_TTTQ.Infrastructure.Data;
using Scan_Product_TTTQ.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository(MySqlConnectionFactory connectionFactory)
       : BaseRepository(connectionFactory), IUserRepository
    {
        public async Task<User> GetUserByEmail(string email)
        {
           var query = "SELECT * FROM User WHERE Email = @Email";
            return await _connection.QueryFirstOrDefaultAsync<User>(query, new { Email = email });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.Commands;
using Application.Products.Interfaces;
using Dapper;
using Scan_Product_TTTQ.Domain.Entities;
using Scan_Product_TTTQ.Infrastructure.Data;
using Scan_Product_TTTQ.Infrastructure.Repositories;

namespace Infrastructure.Repositories
{
    public class ProductRepository(MySqlConnectionFactory connectionFactory)
        : BaseRepository(connectionFactory), IProductRepository
    {
        
        public  async Task AddProduct(Product product)
        {

            var sql = @"INSERT INTO Product (id,name, description, price, quantity, category_id, barcode,image) 
                        VALUES (UUID(),@Name, @Description, @Price, @Quantity, @CategoryId, @Barcode, @Image)";
            await _connection.ExecuteAsync(sql, product);
        }

        public Task<IEnumerable<Product>> GetAllProduct()
        {
            var sql = @"SELECT * FROM Product";
            return _connection.QueryAsync<Product>(sql);
        }

        public Task<Product> GetProductByBarcode(string Barcode)
        {
           var sql = @"SELECT * FROM Product WHERE barcode = @Barcode";
            return _connection.QueryFirstOrDefaultAsync<Product>(sql, new { Barcode });
        }

        Task<IEnumerable<Product>> IProductRepository.GetListProductByCategory(string CategoryId)
        {
            var sql = @"SELECT * FROM Product WHERE category_id = @CategoryId";
            return _connection.QueryAsync<Product>(sql, new { CategoryId });
        }
    }
}

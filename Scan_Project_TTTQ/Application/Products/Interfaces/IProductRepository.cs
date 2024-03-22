using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Products.Commands;
using Scan_Product_TTTQ.Domain.Entities;

namespace Application.Products.Interfaces
{
    public interface IProductRepository
    {
        Task AddProduct(Scan_Product_TTTQ.Domain.Entities.Product product);

        Task<IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>> GetListProductByCategory(string CategoryId);

        Task<IEnumerable<Product>> GetAllProduct();

        Task<Scan_Product_TTTQ.Domain.Entities.Product> GetProductByBarcode(string Barcode);
    }
}

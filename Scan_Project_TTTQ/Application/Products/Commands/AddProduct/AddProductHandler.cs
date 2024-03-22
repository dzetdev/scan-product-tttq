using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.Interfaces;
using MediatR;

namespace Application.Products.Commands.AddProduct
{
    public class AddProductHandler : IRequestHandler<AddProductRequest, Scan_Product_TTTQ.Domain.Entities.Product>
    {
        readonly IProductRepository _productRepository;

        public AddProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Scan_Product_TTTQ.Domain.Entities.Product> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            Scan_Product_TTTQ.Domain.Entities.Product product = new()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Quantity = request.Quantity,
                CategoryId = request.CategoryId,
                Barcode = request.Barcode,
                Image = request.Image
            };

            await _productRepository.AddProduct(product);
            return product;
        }
    }
}

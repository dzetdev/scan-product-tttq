using Application.Products.Interfaces;
using MediatR;
using Scan_Product_TTTQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetAllProduct
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductRequest, IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>>
    {
        readonly IProductRepository _productRepository;

        public GetAllProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        Task<IEnumerable<Product>> IRequestHandler<GetAllProductRequest, IEnumerable<Product>>.Handle(GetAllProductRequest request, CancellationToken cancellationToken)
        {
           return _productRepository.GetAllProduct();
        }
    }
}

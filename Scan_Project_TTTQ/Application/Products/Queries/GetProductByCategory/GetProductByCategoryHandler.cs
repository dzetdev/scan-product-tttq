using Application.Products.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductByCategory
{
    public class GetProductByCategoryHandler : IRequestHandler<GetProductByCategoryRequest, IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>>
    {

        readonly IProductRepository _productRepository;

        public GetProductByCategoryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>> Handle(GetProductByCategoryRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.GetListProductByCategory(request.CategoryId);
        }
    }
}

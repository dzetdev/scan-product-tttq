using Application.Products.Interfaces;
using MediatR;
using Scan_Product_TTTQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductByBarcode
{
    public class GetProductByBarcodeHandler : IRequestHandler<GetProductByBarcodeRequest, Product>
    {
        readonly IProductRepository _productRepository;

        public GetProductByBarcodeHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(GetProductByBarcodeRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.GetProductByBarcode(request.Barcode);
        }
    }
}

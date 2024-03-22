using Application.Products.Commands.AddProduct;
using Application.Products.Queries;
using Application.Products.Queries.GetAllProduct;
using Application.Products.Queries.GetProductByBarcode;
using Application.Products.Queries.GetProductByCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scan_Product_TTTQ.Controllers;

namespace WebApi.Controllers
{

    public class ProductController : BaseApiController
    {
        [HttpPost]
        public Task<Scan_Product_TTTQ.Domain.Entities.Product> AddProductAsync(AddProductRequest request)
        {
            return Mediator.Send(request);
        }

        [HttpGet("GetListProductByCategory")]
        public Task<IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>> GetListProductByCategoryAsync(string CategoryId)
        {

            return Mediator.Send(new GetProductByCategoryRequest(CategoryId));
        }

        [HttpGet("GetAllProduct")]
        public Task<IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>> GetAllProductAsync()
        {
            return Mediator.Send(new GetAllProductRequest());
           
        }

        [HttpGet("GetProductByBarcode")]
        public Task<Scan_Product_TTTQ.Domain.Entities.Product> GetProductByBarcodeAsync(string Barcode)
        {
            return Mediator.Send(new GetProductByBarcodeRequest(Barcode));
        }
    }
}

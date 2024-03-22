using MediatR;
using Scan_Product_TTTQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductByCategory
{
    public class GetProductByCategoryRequest : IRequest<IEnumerable<Product>>
    {
        public GetProductByCategoryRequest(string categoryId)
        {
            CategoryId = categoryId;
        }

        public string CategoryId { get; set; }
    }
}

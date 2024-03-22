using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetAllProduct
{
    public class GetAllProductRequest : IRequest<IEnumerable<Scan_Product_TTTQ.Domain.Entities.Product>>
    {
    }
}

using MediatR;
using Scan_Product_TTTQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductByBarcode
{
    public class GetProductByBarcodeRequest : IRequest<Product>
    {
        public GetProductByBarcodeRequest(string barcode)
        {
            Barcode = barcode;
        }

        public string Barcode { get; set; }
    }
}

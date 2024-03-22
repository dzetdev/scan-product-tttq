﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.AddProduct
{
    public class AddProductRequest : IRequest<Scan_Product_TTTQ.Domain.Entities.Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int CategoryId { get; set; }
        public string Barcode { get; set; }
        public string Image { get; set; }
    }
}

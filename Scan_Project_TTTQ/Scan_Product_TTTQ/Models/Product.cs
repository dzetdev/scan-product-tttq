using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scan_Product_TTTQ.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public Guid CategoryId { get; set; }
        public string Barcode { get; set; }
        public string Image { get; set; }
    }
}

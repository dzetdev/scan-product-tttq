using Scan_Product_TTTQ.Application.Common.Enums;
using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal? Price { get; set; }
    public int? Quantity { get; set; }
    public int CategoryId { get; set; }
    public string Barcode { get; set; }
    public string Image { get; set; }
}
using Scan_Product_TTTQ.Domain.Common;
using Scan_Product_TTTQ.Domain.Entities;

namespace Scan_Product_TTTQ.Domain.Subjects;

public class OrderDetail : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int? Quantity { get; set; }
    public float? Price { get; set; }
}
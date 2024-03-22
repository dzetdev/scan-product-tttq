using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;

public class Order : BaseEntity
{
    public string CustomerName { get; set; }
    public string EmployeeName { get; set; }
    public string Phone { get; set; }
    public float? Total { get; set; }
    public DateTime? Date { get; set; }
    public string Status { get; set; }
    public Guid UserId { get; set; }
}
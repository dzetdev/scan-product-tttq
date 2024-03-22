using Scan_Product_TTTQ.Application.Common.Enums;
using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public Guid ParentId { get; set; }
    public Category Parent { get; set; }
}
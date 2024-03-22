using Scan_Product_TTTQ.Application.Common.Enums;
using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;

public class Cart : BaseEntity
{
    public string UserId { get; set; }
    public Guid User { get; set; }

}
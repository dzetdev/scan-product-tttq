using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scan_Product_TTTQ.Application.Common.Enums;
using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;
public class Item : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid CartId { get; set; }
    public int? Quantity { get; set; }
}


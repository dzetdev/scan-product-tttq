using System.ComponentModel.DataAnnotations.Schema;

namespace Scan_Product_TTTQ.Domain.Common;
public abstract class BaseEntity
{
    public Guid Id { get; set; }

}

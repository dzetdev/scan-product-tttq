using Scan_Product_TTTQ.Application.Common.Enums;
using Scan_Product_TTTQ.Domain.Common;

namespace Scan_Product_TTTQ.Domain.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public RoleEnum Role { get; set; }
    public StatusEnum Status { get; set; }

}
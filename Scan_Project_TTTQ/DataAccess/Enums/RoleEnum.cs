namespace Scan_Product_TTTQ.Application.Common.Enums
{
    public enum RoleEnum
    {
        ADMIN = 1,
        MANAGEMENT = 2,
        SELLER = 3,
        CUSTOMER = 4
    }

    public static class RoleEnumExtensions
    {
        public static RoleEnum GetRoleEnum(string role)
        {
            return role switch
            {
                "ADMIN" => RoleEnum.ADMIN,
                "TENANT" => RoleEnum.MANAGEMENT,
                "USER" => RoleEnum.SELLER,
                "GUEST" => RoleEnum.CUSTOMER,
                _ => RoleEnum.CUSTOMER
            };
        }
    }
}
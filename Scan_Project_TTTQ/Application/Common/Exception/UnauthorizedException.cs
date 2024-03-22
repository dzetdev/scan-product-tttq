using System.Net;

namespace Scan_Product_TTTQ.Application.Common.Exception;

public class UnauthorizedException : CustomException
{
    public UnauthorizedException(string message)
       : base(message, null, HttpStatusCode.Unauthorized)
    {
    }
}
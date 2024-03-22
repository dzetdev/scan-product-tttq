using System.Net;

namespace Scan_Product_TTTQ.Application.Common.Exception;

public class ForbiddenException : CustomException
{
    public ForbiddenException(string message)
        : base(message, null, HttpStatusCode.Forbidden)
    {
    }
}
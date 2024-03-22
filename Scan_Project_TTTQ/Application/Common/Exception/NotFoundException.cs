using System.Net;

namespace Scan_Product_TTTQ.Application.Common.Exception;

public class NotFoundException : CustomException
{
    public NotFoundException(string message)
        : base(message, null, HttpStatusCode.NotFound)
    {
    }
}
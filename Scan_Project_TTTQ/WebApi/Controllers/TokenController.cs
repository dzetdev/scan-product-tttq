using Scan_Product_TTTQ.Application.Identity.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace Scan_Product_TTTQ.Controllers;

public class TokenController : BaseApiController
{
    [HttpPost]
    public Task<TokenResponse> GetTokenAsync(TokenRequest request)
    {
        return Mediator.Send(request);
    }

}
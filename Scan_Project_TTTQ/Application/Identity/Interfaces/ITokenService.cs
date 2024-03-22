
using Scan_Product_TTTQ.Application.Identity.Tokens;
using Scan_Product_TTTQ.Domain.Entities;

namespace Scan_Product_TTTQ.Application.Identity.Tokens;

public interface ITokenService
{
    Task<TokenResponse> GetTokenAsync(TokenRequest request);
    TokenResponse GenerateToken(User user);
}
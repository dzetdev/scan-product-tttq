using FluentValidation;
using FSH.Starter.Application.Common.Validation;
using MediatR;

namespace Scan_Product_TTTQ.Application.Identity.Tokens;

public class TokenRequest : IRequest<TokenResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class TokenRequestValidator : CustomValidator<TokenRequest>
{
    public TokenRequestValidator()
    {
        RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Invalid Email Address.");

        RuleFor(p => p.Password).Cascade(CascadeMode.Stop)
            .NotEmpty();
    }
}

public class TokenRequestHandler : IRequestHandler<TokenRequest, TokenResponse>
{
    private readonly ITokenService _tokenService;

    public TokenRequestHandler(ITokenService tokenService) => _tokenService = tokenService;

    public async Task<TokenResponse> Handle(TokenRequest request, CancellationToken cancellationToken)
    {
        return await _tokenService.GetTokenAsync(request);
    }
}
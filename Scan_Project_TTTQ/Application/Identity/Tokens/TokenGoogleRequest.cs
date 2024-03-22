using Scan_Product_TTTQ.Application.Identity.Tokens;
using FluentValidation;
using FSH.Starter.Application.Common.Validation;
using MediatR;

namespace Scan_Product_TTTQ.Application.Identity.Tokens;

public class TokenGoogleRequest : IRequest<TokenResponse>
{
    public string Email { get; set; }
}

public class TokenGoogleRequestValidator : CustomValidator<TokenGoogleRequest>
{
    public TokenGoogleRequestValidator()
    {
        RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("Invalid Email Address.");
    }
}


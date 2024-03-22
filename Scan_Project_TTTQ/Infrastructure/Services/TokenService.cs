using MailKit;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Scan_Product_TTTQ.Application.Common.Exception;
using Scan_Product_TTTQ.Application.Identity.Tokens;
using Scan_Product_TTTQ.Application.Users;
using Scan_Product_TTTQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Models.Constants;

namespace Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _repository;

        public TokenService(IConfiguration config, IUserRepository repository)
        {
            _config = config;
            _repository = repository;
        }

        public async Task<TokenResponse> GetTokenAsync(TokenRequest request)
        {
            User user = await _repository.GetUserByEmail(request.Email);

            var isValid = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

            if (user == null && !isValid)
            {
                throw new UnauthorizedException("Email or password is incorrect");
            }

            return GenerateToken(user);
        }


        public TokenResponse GenerateToken(User user)
        {
            var claims = new[]
            {
            new Claim("Id", user.Id.ToString()), new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("name",   user.FullName ?? string.Empty),
            new Claim("phone",  user.Phone ?? string.Empty),
        };


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                expires: DateTime.UtcNow.AddMinutes(AuthConstant.EXPIRE_TIME),
                claims: claims,
                signingCredentials: signInCred
            );

            var jwtHandler = new JwtSecurityTokenHandler();
            return new TokenResponse { Token = jwtHandler.WriteToken(token) };
        }
    }
}

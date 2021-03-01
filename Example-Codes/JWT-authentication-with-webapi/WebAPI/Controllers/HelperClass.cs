using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public class HelperClass
    {
        IConfiguration _config;
        public HelperClass(IConfiguration config)
        {
            _config = config;
        }
        /// <summary>
        /// returns LoginModel if user name is atakan and password is 123 (for demo purposes), 
        /// otherwise returns null LoginModel object
        /// </summary>
        public LoginModel AuthenticateUser(LoginModel login)
        {
            LoginModel user = null;
            if (login.Name == "atakan" && login.Password == "123")
            {
                user = new LoginModel { Name = "_atakan", Password = "_123" };
            }
            return user;
        }

        public string GenerateJSONWebToken(LoginModel userinfo)
        {
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            // with securityKey, we create secure tokens which no one can generate without knowing the "Key"
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                // Writing login information inside toke is not safe, its better to write userId in token.
                new Claim(JwtRegisteredClaimNames.Sub,userinfo.Name),
                new Claim(JwtRegisteredClaimNames.Email,userinfo.Password),
                // Guid generates unique string
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: credentials);
            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;
        }
    }
}

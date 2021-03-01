using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private HelperClass _helper;
        public LoginController(IConfiguration config)
        {
            _config = config;
            _helper = new HelperClass(config);
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginValue)
        {
            LoginModel login = new LoginModel();
            login.Name = loginValue.Name;
            login.Password = loginValue.Password;

            IActionResult response = Unauthorized();

            var user = _helper.AuthenticateUser(login);

            if (user != null)
            {
                var tokenStr = _helper.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenStr });
            }

            return response;
        }

        [Authorize]
        [HttpGet]
        // requires JWT token send via header or authorization jwt bearer
        public string WhoIsThis()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var userName = claim[0].Value;
            var password = claim[1].Value;
            return "Welcome " + userName + " your password is: " + password;
        }
    }
}

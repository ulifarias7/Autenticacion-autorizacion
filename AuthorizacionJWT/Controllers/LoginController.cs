using AuthorizacionJWT.Constant;
using AuthorizacionJWT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace AuthorizacionJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(LoginModels userlogin)
        {

            var user = Authenticate(userlogin);

            

            if (user != null)
            {

                var token = generartoken(user);

                return Ok(token);
            }

            return NotFound("usario no encontrado");

        }


        private UserModels Authenticate(LoginModels loginModels)
        {
            var currentUser = UserContant.Users.FirstOrDefault(user =>user.Username.ToLower() == loginModels.Username.ToLower() 
            && user.Password == loginModels.Password);


            if (currentUser != null)
            {
                return currentUser;
            }

            return null;
        }


        private string generartoken(UserModels user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Crear los claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimTypes.Role, user.Rol),
            };


            // Crear el token

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

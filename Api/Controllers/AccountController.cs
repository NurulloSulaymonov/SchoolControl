using Domain.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{

    public class AccountController : BaseController
    {
        private readonly JwtConfiguration _jwtOptions;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(IOptions<JwtConfiguration> jwtOptions, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _jwtOptions = jwtOptions.Value;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserInfo model)
        {

            if (model.Username != null || model.Password != null)
            {
                var user = await _userManager.FindByEmailAsync(model.Username);

                if (user != null)
                {
                    if (await _userManager.CheckPasswordAsync(user, model.Password) == false) return BadRequest("password or username is not correct");

                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _jwtOptions.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.Id.ToString()),
                    new Claim("Email", user.Email),
                    new Claim(ClaimTypes.Role,"admin")
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_jwtOptions.Issuer,
                     _jwtOptions.Audience,
                      claims,
                       expires: DateTime.UtcNow.AddMinutes(1),
                      signingCredentials: signIn);

                    string generatedToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(generatedToken);
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private IdentityUser GetUser(string email, string password)
        {
            var list = new List<IdentityUser>()
            {
                new IdentityUser(){UserName ="test", Email =  "test@gmail.com"}
            };
            return list.FirstOrDefault(u => u.Email == email);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            var identity = new IdentityUser()
            {
                UserName = model.Username,
                Email = model.Username
            };
            var result = await _userManager.CreateAsync(identity, model.Password);
            if (result.Succeeded) return Ok();
            else return BadRequest(result.Errors);

        }



    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using studmonBackend.Data.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace studmonBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<Tanar> _userManager;
        //private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;
        public AuthController(UserManager<Tanar> userManager)
        {
            _userManager = userManager;
            //_configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var claim = new List<Claim> 
                { 
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
                };
                foreach (var role in await _userManager.GetRolesAsync(user))
                {
                    claim.Add(new Claim(ClaimTypes.Role, role));
                }
                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"));
                var token = new JwtSecurityToken(
                issuer: "http://www.security.org", audience: "http://www.security.org",
                claims: claim, expires: DateTime.Now.AddMinutes(60),
                signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPut]
        public async Task<IActionResult> InsertUser([FromBody] RegisterViewModel model)
        {
            var user = new Tanar
            {
                Id = model.ID,
                nev =  model.nev,
                Email = model.Email,
                PasswordHash = model.Password,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            await _userManager.CreateAsync(user);
            await _userManager.AddToRoleAsync(user, "Tanar");
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserInfos()
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            if (user != null)
            {
                return Ok(new
                {
                    neptunKod = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    nev = user.nev,
                    orakColl = user.orakColl,
                    Roles = await _userManager.GetRolesAsync(user)
                });
            }
            return Unauthorized();
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteMyself()
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }


    }
}

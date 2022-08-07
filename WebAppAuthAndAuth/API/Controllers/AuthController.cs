using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IConfiguration configuration;

        // In order to get the secret key from the configuration file we use dependency injection
        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // verify the credentials
        [HttpPost]
        public IActionResult Authenticate([FromBody]Credentials credential)
        {
            if (credential.UserName == "admin" && credential.Password == "password")
            {
                // Creating the security context
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@mywebsite.com"),
                    new Claim("Department","HR"),
                    new Claim("Admin","true"),
                    new Claim("Manager","true"),
                    new Claim("EmploymentDate","2021-05-01")
                };
                // Identity Creation
                //var identity = new ClaimsIdentity(claims, "MyCookieAuth");

                //// Once we have the indentity what we needs is a claims principle
                //ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                //var authProperties = new AuthenticationProperties
                //{
                //    IsPersistent = Credential.RememberMe
                //};
                // we have the security context but now we need to encrypt and serialize thr security context
                // we use the HttpContext object
                // this is going to serialize the claims principal into a string and then encrypt that string
                // and save that as a cooki inside HttpContext
                // similarly there is a sign out async which can helpp us get rid of the cookie so we can implement that in a
                // log out page 
                //await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal, authProperties);

                //return RedirectToPage("/Index");

                // expires time for the token
                var expiresAt = DateTime.UtcNow.AddMinutes(10);

                // json token is just a string
                return Ok(new
                {
                    access_token = CreateToken(claims,expiresAt),
                    expires_at = expiresAt,
                });
            }

            ModelState.AddModelError("Unauthorized", "You are not authorized to acceess the end point");
            return Unauthorized(ModelState);
        }

        /*
         * Here we are going to verify the credentials 
         * and because this is HttpPost we want the body to come from the body 
         * We want the token to contain claims 
         * In order to generate a token we need to use a nuget package 
         * 
         * We need System.IdentityModel.Tokens.Jwt to generate token 
         * We need JwtBearer to cinfigure it later on
         * https: //jwt.io/ --> here you can see three parts of the token 
         */

        private string CreateToken(IEnumerable<Claim> claims, DateTime expiresAt)
        {
            // We need to have a key which is inside appsetting.json
            var secretKey = Encoding.ASCII.GetBytes(configuration.GetValue<string>("SecretKey"));

            var jwt = new JwtSecurityToken(
                claims: claims,
                notBefore:DateTime.UtcNow,
                expires:expiresAt,
                signingCredentials:new SigningCredentials(
                    new SymmetricSecurityKey(secretKey),
                    SecurityAlgorithms.HmacSha256Signature));

            // this return result is the token itlsef
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }

    // This class is for the purpose of receiving the information from the body 
    public class Credentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

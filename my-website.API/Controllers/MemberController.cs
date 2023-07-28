using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using my_website.Application.DTOS.UserDTOS;
using my_website.Domain.Entities;

namespace my_website.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public static IWebHostEnvironment _webHostEnvironment;

        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager; _signInManager = signInManager; _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> SignIn([FromBody] UserLoginDto request)
        {
            var hasUser = await _userManager.FindByEmailAsync(request.Email);

            if (hasUser == null)
            {
                return null!;
            }

            await _userManager.UpdateSecurityStampAsync(hasUser);

            var signInResult = await _signInManager.PasswordSignInAsync(hasUser, request.Password, request.RememberMe, true);

            var cookieValue = "myCookieValue";
            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(7),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None
            };
            Response.Cookies.Append("MyWebsiteCookie", cookieValue, cookieOptions);

            if (signInResult.Succeeded)
            {
                return Ok(new { cookie = cookieValue });
            }

            return BadRequest();
        }

    }
}

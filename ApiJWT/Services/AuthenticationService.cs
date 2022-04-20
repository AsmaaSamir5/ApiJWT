using ApiJWT.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ApiJWT.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthenticationService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AuthModel> RegisterAsync(RegisterModel model)
        {
            if(await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthModel { Message = "Email is already Exist!" };

            if (await _userManager.FindByNameAsync(model.UserName) is not null)
                return new AuthModel { Message = "UserName is already Exist!" };

            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Empty;
                foreach(var error in result.Errors)
                {
                    errors += $"{error.Description}, ";
                }
                return new AuthModel { Message = errors };
            }
            await _userManager.AddToRoleAsync(user, "User");

        }
    }
}

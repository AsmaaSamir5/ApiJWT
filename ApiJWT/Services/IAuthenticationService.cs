using ApiJWT.Models;
using System.Threading.Tasks;

namespace ApiJWT.Services
{
    public interface IAuthenticationService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}

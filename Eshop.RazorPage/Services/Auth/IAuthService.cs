using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Auth;
using System.Threading.Tasks;

namespace Eshop.RazorPage.Services.Auth;

public interface IAuthService
    {
    Task<ApiResult<LoginResponse>?> login(LoginCommand command);
    Task<ApiResult> Register(RegisterCommand command);
    Task<ApiResult<LoginResponse>> RefreshToken();
    Task<ApiResult> Logout();

}

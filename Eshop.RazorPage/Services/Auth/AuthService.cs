using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Auth;
using System.Net;

namespace Eshop.RazorPage.Services.Auth;

public class AuthService: IAuthService
{
    private HttpClient _client;

    public AuthService(HttpClient client)
    {
        _client = client;
    }

    
    //3/21

    public async Task<ApiResult<LoginResponse>?> login(LoginCommand command)
    {
        var result = await _client.PostAsJsonAsync("/Auth/Login", command);
        if(result.StatusCode != HttpStatusCode.OK)
            return new ApiResult<LoginResponse>() { IsSuccess=false};  
        return await result.Content.ReadFromJsonAsync<ApiResult<LoginResponse>>();
    }

    public Task<ApiResult> Logout()
    {
        throw new NotImplementedException();
    }

    public Task<ApiResult<LoginResponse>> RefreshToken()
    {
        throw new NotImplementedException();
    }

    public Task<ApiResult> Register(RegisterCommand command)
    {
        throw new NotImplementedException();
    }
}

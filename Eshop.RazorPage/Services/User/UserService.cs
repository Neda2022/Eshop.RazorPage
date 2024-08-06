namespace Eshop.RazorPage.Services.User;

public class UserService: IUserService
{
    private HttpClient _client;

    public UserService(HttpClient client)
    {
        _client = client;
    }
}
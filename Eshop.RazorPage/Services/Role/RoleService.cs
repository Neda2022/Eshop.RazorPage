namespace Eshop.RazorPage.Services.Role;

public class RoleService : IRoleService
{
    private HttpClient _client;

    public RoleService(HttpClient client)
    {
        _client = client;
    }
}
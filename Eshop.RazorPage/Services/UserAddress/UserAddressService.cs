namespace Eshop.RazorPage.Services.UserAddress;

public class UserAddressService: IUserAddressService
{
    private HttpClient _client;

    public UserAddressService(HttpClient client)
    {
        _client = client;
    }
}
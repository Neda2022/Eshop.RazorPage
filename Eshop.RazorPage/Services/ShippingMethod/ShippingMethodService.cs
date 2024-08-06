namespace Eshop.RazorPage.Services.ShippingMethod;

public class ShippingMethodService: IShippingMethodService
{
    private HttpClient _client;

    public ShippingMethodService(HttpClient client)
    {
        _client = client;
    }
}
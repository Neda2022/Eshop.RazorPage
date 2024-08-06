namespace Eshop.RazorPage.Services.Order;

public class OrderService: IOrderService
{
    private HttpClient _client;

    public OrderService(HttpClient client)
    {
        _client = client;
    }
}
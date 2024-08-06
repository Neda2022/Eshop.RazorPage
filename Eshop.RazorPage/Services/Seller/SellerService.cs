namespace Eshop.RazorPage.Services.Seller;

public class SellerService: ISellerService
{
    private HttpClient _client;

    public SellerService(HttpClient client)
    {
        _client = client;
    }
}
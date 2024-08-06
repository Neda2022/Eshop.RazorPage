namespace Eshop.RazorPage.Services.Product;

public class ProductService: IProductService
{
    private HttpClient _client;

    public ProductService(HttpClient client)
    {
        _client = client;
    }
}
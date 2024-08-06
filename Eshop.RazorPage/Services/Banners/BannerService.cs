namespace Eshop.RazorPage.Services.Banners;

public class BannerService : IBannerService
{
    private HttpClient _client;

    public BannerService(HttpClient client)
    {
        _client = client;
    }
}
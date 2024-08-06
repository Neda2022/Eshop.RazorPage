namespace Eshop.RazorPage.Services.Category;

public class CategoryService: ICategoryService
{
    private HttpClient _client;

    public CategoryService(HttpClient client)
    {
        _client = client;
    }
}
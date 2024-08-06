namespace Eshop.RazorPage.Services.Slider;

public class SliderService: ISliderServiceService
{
    private HttpClient _client;

    public SliderService(HttpClient client)
    {
        _client = client;
    }
}
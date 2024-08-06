using Eshop.RazorPage.Services.Auth;
using Eshop.RazorPage.Services.Banners;
using Eshop.RazorPage.Services.Category;
using Eshop.RazorPage.Services.Comment;
using Eshop.RazorPage.Services.Order;
using Eshop.RazorPage.Services.Product;
using Eshop.RazorPage.Services.Role;
using Eshop.RazorPage.Services.Seller;
using Eshop.RazorPage.Services.ShippingMethod;
using Eshop.RazorPage.Services.Slider;
using Eshop.RazorPage.Services.User;
using Eshop.RazorPage.Services.UserAddress;

namespace Eshop.RazorPage.Infrastructure;

public static class RegisterDependencyServices
{
    public static IServiceCollection RegisterApiServices(this IServiceCollection services)
    {
        var baseAddress = "https://localhost:5001/api/";

        services.AddHttpContextAccessor();

        services.AddHttpClient<IAuthService, AuthService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IShippingMethodService, ShippingMethodService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IBannerService, BannerService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<ICategoryService, CategoryService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<ICommentService, CommentService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IOrderService, OrderService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IProductService, ProductService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IRoleService, RoleService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<ISellerService, SellerService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<ISliderServiceService, SliderService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IUserAddressService, UserAddressService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        services.AddHttpClient<IUserService, UserService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });


        return services;
    }
}

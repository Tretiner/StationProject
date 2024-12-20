using Microsoft.AspNetCore.Components;

namespace StationProject.Services;

public sealed class AppNavigationManager(
    NavigationManager _navManager,
    ILogger<AppNavigationManager> _logger
)
{
    public void NavigateToProducts(int? categoryId = null) =>
        Navigate($"Products/{categoryId}");

    public void FastOrder(int productId) =>
        Navigate($"Order?productid={productId}");

    public void NavigateToFullInfo(int productId) =>
        Navigate($"Product/{productId}");

    public void NavigateToCart() =>
        Navigate("Cart");

    public void NavigateToProfile() =>
        Navigate("Profile");

    private void Navigate(string path)
    {
        _logger.LogInformation("Nav to: {Path}", path);
        _navManager.NavigateTo(path);
    }
}
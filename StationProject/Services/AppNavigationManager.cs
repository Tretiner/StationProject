using Microsoft.AspNetCore.Components;

namespace StationProject.Services;

public sealed class AppNavigationManager(
    NavigationManager _navManager,
    ILogger<AppNavigationManager> _logger
)
{
    public void NavigateToProducts(string? categoryId = null) =>
        Navigate($"Products/{categoryId}");

    public void NavigateToFastItemOrder(string productId) =>
        Navigate($"Order?productid={productId}");

    public void NavigateToFullInfo(string productId) =>
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
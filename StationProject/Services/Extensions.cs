using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace StationProject.Services;

public static class Extensions
{
    public static async Task<int?> GetUserIdAsync(this Task<AuthenticationState> authStateTask)
        => await (await authStateTask).GetUserIdAsync();

    public static async Task<int?> GetUserIdAsync(this AuthenticationState authState)
    {
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            return Convert.ToInt32(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }

        return null;
    }
}
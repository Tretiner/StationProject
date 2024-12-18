using Microsoft.AspNetCore.Identity;
using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public sealed class ApplicationUser : IdentityUser<int>
{
    public Language Language { get; set; }

    public ICollection<Product> PublishedProducts { get; set; } = null!;

    public ICollection<Order> Orders { get; set; } = null!;

    public ICollection<CartItem> CartItems { get; set; } = null!;
}
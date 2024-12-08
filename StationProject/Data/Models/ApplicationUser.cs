using Microsoft.AspNetCore.Identity;

namespace StationProject.Data.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ICollection<Product> PublishedProducts { get; set; } = null!;

    public ICollection<Order> Orders { get; set; } = null!;

    public ICollection<KorzinaItem> KorzinedItems { get; set; } = null!;
}
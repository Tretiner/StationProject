using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class Product : BaseEntity
{
    public int Id { get; set; }
    public Language Language { get; set; }

    public int VendorId { get; set; }
    public ApplicationUser Vendor { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public int PriceId { get; set; }
    public Price Price { get; set; } = null!;

    public ICollection<ProductImage> Images { get; set; } = null!;

    public int CountId { get; set; }
    public ProductCount Count { get; set; } = null!;

    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Characteristics { get; set; }
}
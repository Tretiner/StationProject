using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class Category : BaseEntity
{
    public int Id { get; set; }
    public Language Language { get; set; }

    public string Name { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = null!;
}
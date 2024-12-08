using System.ComponentModel.DataAnnotations;

namespace StationProject.Data.Models;

public class Product : BaseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string PublishedByKey { get; set; } = null!;

    public ApplicationUser PublishedBy { get; set; } = null!;

    public string CategoryKey { get; set; } = null!;
    public Category Category { get; set; } = null!;


    public string[] ImageUrls { get; set; } = null!;

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public int TotalCount { get; set; }
    public int MinCount { get; set; }
    public int Price { get; set; }

    [StringLength(10)]
    public string PriceTemplate { get; set; } = null!;
}
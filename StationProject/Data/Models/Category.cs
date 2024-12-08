using System.ComponentModel.DataAnnotations;

namespace StationProject.Data.Models;

public class Category : BaseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public string[] ImageUrls { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = null!;
}
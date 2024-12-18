namespace StationProject.Data.Models;

public sealed class ProductImage
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public string Url { get; set; } = null!;
}
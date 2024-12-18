namespace StationProject.Data.Models;

public sealed class ProductStorageInfo
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public int Count { get; set; }
}
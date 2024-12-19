namespace StationProject.Domain;

public record ProductShortInfo
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public string VendorName { get; set; }
    public string Price { get; set; }
    public bool IsAddedToCart { get; set; }
}
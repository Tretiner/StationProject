namespace StationProject.Domain;

public record ProductInfo
{
    public string Id { get; init; }
    public string[] ImageUrls { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public string VendorName { get; set; }
    public string Price { get; init; }
    public bool IsAddedToCart { get; set; }

    public string FirstImageOrPlaceholderUrl() =>
        ImageUrls.FirstOrDefault() ?? Consts.PlaceholderUrl;
}
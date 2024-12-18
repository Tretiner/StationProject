namespace StationProject.Domain;

public record ProductShortInfo
{
    public string Id { get; set; }
    public string[] ImageUrls { get; set; }
    public string Name { get; set; }
    public string VendorName { get; set; }
    public string Price { get; set; }
    public bool IsAddedToCart { get; set; }

    public string FirstImageOrPlaceholderUrl() =>
        ImageUrls.FirstOrDefault() ?? Consts.PlaceholderUrl;
}
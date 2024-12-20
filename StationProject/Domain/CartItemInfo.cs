namespace StationProject.Domain;

public sealed record CartItemInfo
{
    public CartItemInfo(int Id,
        int Count,
        double Price,
        string PriceTemplate,
        ProductShortInfo Source)
    {
        this.Id = Id;
        this.Count = Count;
        this.Price = Price;
        this.PriceTemplate = PriceTemplate;
        this.Source = Source;
    }

    public int SelectedCount { get; set; } = 1;
    public bool IsSelected { get; set; }
    public int Id { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
    public string PriceTemplate { get; set; }
    public ProductShortInfo Source { get; set; }

    public void ChangeChecked()
    {
        IsSelected = !IsSelected;
    }

    public void Deconstruct(
        out int Id,
        out int Count,
        out double Price,
        out string PriceTemplate,
        out ProductShortInfo Source)
    {
        Id = this.Id;
        Count = this.Count;
        Price = this.Price;
        PriceTemplate = this.PriceTemplate;
        Source = this.Source;
    }
}
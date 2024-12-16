namespace StationProject.Domain;

public sealed record CartItemInfo(
    string Id,
    int Count,
    int Price,
    string PriceTemplate,
    ProductShortInfo Source
)
{
    public int SelectedCount { get; set; } = 1;
    public bool IsSelected { get; set; }

    public void ChangeChecked()
    {
        IsSelected = !IsSelected;
    }
}
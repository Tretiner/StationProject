namespace StationProject.Domain;

public sealed record CartItemInfo(
    int Id,
    int Count,
    double Price,
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
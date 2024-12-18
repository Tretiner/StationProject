using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class Price
{
    public int Id { get; set; }

    public Language Language { get; set; }

    public double Value { get; set; }

    public int TemplateId { get; set; }
    public PriceTemplate Template { get; set; } = null!;

    public string FormattedPrice
        => string.Format(Template.Value, Value);
}
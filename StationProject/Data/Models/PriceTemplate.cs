using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class PriceTemplate
{
    public int Id { get; set; }

    public Language Language { get; set; }

    public string Value { get; set; } = null!;
}
namespace StationProject.Data.Models;

public sealed class UserMonthlyActivityStat : BaseEntity
{
    public int Id { get; set; }

    public required long TotalSiteViews { get; set; }
}
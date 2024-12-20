namespace StationProject.Data.Models;

public sealed class UserMonthlyActivityStat
{
    public int Id { get; set; }

    public required long TotalSiteViews { get; set; }

    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}
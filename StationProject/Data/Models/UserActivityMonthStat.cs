using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationProject.Data.Models;

public class UserActivityMonthStat : BaseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required long TotalSiteViews { get; set; }
}
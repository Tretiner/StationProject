using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public class OrderItem : BaseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string OrderKey { get; set; }
    public string SourceKey { get; set; }
    public Product? Source { get; set; }

    public int Count { get; set; } = 1;

    public OrderItemStatus Status { get; set; } = OrderItemStatus.Preparing;

    [StringLength(100)]
    public string? StatusString { get; set; }

    public DateTime ArrivalTime { get; set; }
    public int ArrivalMovedCount { get; set; }
}
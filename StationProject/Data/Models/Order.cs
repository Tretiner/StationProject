using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public class Order : BaseEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public ICollection<OrderItem> Items { get; set; } = null!;

    public OrderStatus Status { get; set; }

    [StringLength(100)]
    public string? StatusString { get; set; }

    public DateTime ArrivalTime { get; set; }
    public int ArrivalMovedCount { get; set; }
}
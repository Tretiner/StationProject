using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class OrderItem : BaseEntity
{
    public int Id { get; set; }

    public int OrderKey { get; set; }
    public Order Order { get; set; } = null!;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int Count { get; set; }

    public OrderItemStatus Status { get; set; } = OrderItemStatus.Preparing;

    public DateTimeOffset ArrivesAt { get; set; }
    public int ArrivalDelayedTimes { get; set; }

    public string? ItemStatusExtraDesc { get; set; }
}
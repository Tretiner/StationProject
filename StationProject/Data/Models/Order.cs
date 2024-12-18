using StationProject.Data.Models.Enums;

namespace StationProject.Data.Models;

public sealed class Order : BaseEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; } = null!;

    public OrderStatus Status { get; set; } = OrderStatus.Registration;

    public string ArrivalAddress { get; set; } = null!;
    public DateTimeOffset ArrivalTime { get; set; }
}
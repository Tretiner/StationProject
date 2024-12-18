namespace StationProject.Data.Models.Enums;

public enum OrderItemStatus : byte
{
    Preparing,
    Sent,
    Arrived,
    Taken,
    Custom
}
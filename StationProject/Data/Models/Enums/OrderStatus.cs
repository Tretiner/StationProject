namespace StationProject.Data.Models.Enums;

public enum OrderStatus : byte
{
    Preparing,
    Sent,
    Coming,
    Arrived,
    Taken,
    Completed,
    Custom
}
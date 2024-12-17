namespace StationProject.Data.Models.Enums;

public enum OrderStatus : byte
{
    Preparing,
    Sent,
    Coming,
    Arrived,
    Taken,
    Custom,
    Completed
}
namespace StationProject.Data.Models.Enums;

public enum OrderStatus : byte
{
    Registration,
    Preparing,
    Sent,
    Coming,
    Arrived,
    Taken,
    Custom,
    Completed
}
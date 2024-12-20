using StationProject.Data.Models;

namespace StationProject.Domain;

public class FastOrder
{
    public Product Product { get; set; }
    public string Address { get; set; }
}
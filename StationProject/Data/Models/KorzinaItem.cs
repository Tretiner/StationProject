using System.ComponentModel.DataAnnotations;

namespace StationProject.Data.Models;

public class KorzinaItem
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string OwnerId { get; set; } = null!;

    public int Count { get; set; } = 1;

    public Product? Source { get; set; }

}
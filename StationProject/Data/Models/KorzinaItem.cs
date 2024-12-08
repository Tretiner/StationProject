using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationProject.Data.Models;

public class KorzinaItem
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public Product? Source { get; set; }

    public int Count { get; set; } = 1;
}
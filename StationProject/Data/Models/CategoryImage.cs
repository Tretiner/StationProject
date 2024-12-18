namespace StationProject.Data.Models;

public class CategoryImage
{
    public int Id { get; set; }
    public int CategoryId { get; set; }

    public string Url { get; set; } = null!;
}
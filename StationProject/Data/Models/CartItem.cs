using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationProject.Data.Models;

public sealed class CartItem
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;

    public int Count { get; set; } = 1;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
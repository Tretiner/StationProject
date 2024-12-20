using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;

namespace StationProject.Services;

public sealed class CartService(
    ApplicationDbContext _db
    // ,
    // Logger<CartService> _logger
)
{
    public async Task<List<CartItem>> GetUserCart(int userId)
    {
        return await _db.Cart.Where(x => x.UserId == userId)
            .Include(x => x.Product).ThenInclude(x => x.Vendor)
            .Include(x => x.Product).ThenInclude(x => x.Category)
            .Include(x => x.Product).ThenInclude(x => x.Images)
            .Include(x => x.Product).ThenInclude(x => x.Price).ThenInclude(x => x.Template)
            .Include(x => x.Product).ThenInclude(x => x.Count)
            .ToListAsync();
    }

    public async Task AddOrIncrementProduct(int userId, int productId)
    {
        var existingItem = await _db.Cart
            .Include(x => x.Product).ThenInclude(x => x.Count)
            .FirstOrDefaultAsync(x => x.UserId == userId && x.ProductId == productId);

        if (existingItem is not null)
        {
            if (existingItem.Product.Count.Count - existingItem.Count == 1)
            {
                return;
            }

            existingItem.Count++;
            _db.Cart.Update(existingItem);
            // _logger.LogInformation($"Updated item: {existingItem.Id}");
        }
        else
        {
            var newItem = new CartItem
            {
                UserId = userId,
                Product = await _db.Products.FirstAsync(x => x.Id == productId),
                Count = 1,
            };

            await _db.Cart.AddAsync(newItem);

            // _logger.LogInformation($"Added item: {newItem.Product.Name} {newItem.Id}");
        }

        await _db.SaveChangesAsync();
    }

    public async Task RemoveItem(int userId, int itemId)
    {
        var itemToRemove = _db.Cart.First(x => x.Id == itemId);
        _db.Cart.Remove(itemToRemove);

        await _db.SaveChangesAsync();
    }
}
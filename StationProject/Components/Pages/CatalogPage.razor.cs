using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;
using StationProject.Domain;

namespace StationProject.Components.Pages;

public partial class CatalogPage : ComponentBase
{

    [Inject]
    private ApplicationDbContext _dbContext { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await SetProducts();
    }

    private async Task SetProducts()
    {
        List<Product> dbProducts;
        if (CategoryId is null)
        {
            var dbRequest = _dbContext.Products.AsQueryable();

            dbRequest = OrderBy switch
            {
                ProductOrder.Name => dbRequest.OrderBy(x => x.Name),
                ProductOrder.Price => dbRequest.OrderBy(x => x.Price),
                _ => dbRequest,
            };

            dbProducts = await dbRequest.Include(x => x.PublishedBy).ToListAsync();
        }
        else
        {
            var category = await _dbContext.Category
                .Include(x => x.Products).ThenInclude(x => x.PublishedBy)
                .FirstAsync(x => x.Id == CategoryId);

            var sortedProductsQuery = OrderBy switch
            {
                ProductOrder.Name => category.Products.OrderBy(x => x.Name),
                ProductOrder.Price => category.Products.OrderBy(x => x.Price),
                _ => category.Products.AsEnumerable(),
            };

            dbProducts = sortedProductsQuery.ToList();
        }

        ProductList = dbProducts.Select(Map).ToList();
    }

    private static ProductShortInfo Map(Product product) => new()
    {
        Id = product.Id,
        ImageUrls = product.ImageUrls,
        Name = product.Name,
        VendorName = product.PublishedBy.UserName,
        Price = string.Format(product.PriceTemplate, product.Price),
        IsAddedToCart = false,
    };

    public List<ProductShortInfo> ProductList { get; set; } = [];

    private async Task AddOrIncrementKorzinaItem(string productId)
    {
        var existingItem = await _dbContext.KorzinaItems
            .FirstOrDefaultAsync(x => x.Source != null && x.Source.Id == productId);

        if (existingItem is not null)
        {
            existingItem.Count++;
            _dbContext.KorzinaItems.Update(existingItem);
            Logger.LogInformation($"Updated item: {existingItem.Id}");
        }
        else
        {
            var newItem = new KorzinaItem
            {
                Source = await _dbContext.Products.FindAsync(productId),
                Count = 1
            };

            await _dbContext.KorzinaItems.AddAsync(newItem);
            Logger.LogInformation($"Added item: {newItem.Source.Name} {existingItem.Id}");
        }

        await _dbContext.SaveChangesAsync();
    }
}
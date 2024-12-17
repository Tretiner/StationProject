using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;
using StationProject.Domain;

namespace StationProject.Components.Pages;

public partial class CatalogPage : ComponentBase
{

    [Inject]
    private ApplicationDbContext _dbContext { get; set; } = null!;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await SetProducts();
    }

    private async Task SetProducts()
    {
        IQueryable<Product> dbRequest;

        Categories = await _dbContext.Category.ToListAsync();

        if (CategoryId is null)
        {
            dbRequest = _dbContext.Products.Include(x => x.PublishedBy);
        }
        else
        {
            dbRequest = _dbContext.Category
                .Include(x => x.Products).ThenInclude(x => x.PublishedBy)
                .Where(x => x.Id == CategoryId)
                .SelectMany(x => x.Products);
        }

        dbRequest = OrderBy switch
        {
            ProductOrder.Name => dbRequest.OrderBy(x => x.Name),
            ProductOrder.Price => dbRequest.OrderBy(x => x.Price),
            _ => dbRequest,
        };

        IEnumerable<Product> products = await dbRequest.ToListAsync();

        var words = QueryText.Split();
        if (words.Length > 0)
        {
            products = products.Where(x => words.Any(w => x.Name.Contains(w, StringComparison.InvariantCultureIgnoreCase)));
        }

        ProductList = products.Select(Map).ToList();
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
                Source = await _dbContext.Products.FirstAsync(x => x.Id == productId),
                Count = 1,
                OwnerId = await GetUserId()
            };

            await _dbContext.KorzinaItems.AddAsync(newItem);
            Logger.LogInformation($"Added item: {newItem.Source.Name} {newItem.Id}");
        }

        await _dbContext.SaveChangesAsync();
    }

    async Task<string> GetUserId()
    {
        var user = (await authenticationStateTask).User;
        var userid = user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
        return userid;
    }
}
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;
using StationProject.Domain;

namespace StationProject.Components.Pages;

public partial class ProductPage : ComponentBase
{
    [Inject]
    private ApplicationDbContext _dbContext { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        var product = await _dbContext.Products
            .Include(x => x.Vendor)
            .FirstOrDefaultAsync(x => x.Id == ProductId);

        if (product is not null)
        {
            Item = Map(product);
        }
    }

    private static ProductInfo Map(Product product) => new()
    {
        Id = product.Id,
        ImageUrls = product.Images.Select(x => x.Url).ToArray(),
        Name = product.Name,
        Description = product.Description,
        VendorName = product.Vendor.UserName,
        Price = product.Price.FormattedPrice,
        IsAddedToCart = false,
    };

    // private async Task SetProducts()
    // {
    //     List<Product> dbProducts;
    //     if (CategoryId is null)
    //     {
    //         var dbRequest = _dbContext.Products.AsQueryable();
    //
    //         dbRequest = OrderBy switch
    //         {
    //             ProductOrder.Name => dbRequest.OrderBy(x => x.Name),
    //             ProductOrder.Price => dbRequest.OrderBy(x => x.Price),
    //             _ => dbRequest,
    //         };
    //
    //         dbProducts = await dbRequest.Include(x => x.PublishedBy).ToListAsync();
    //     }
    //     else
    //     {
    //         var category = await _dbContext.Category
    //             .Include(x => x.Products).ThenInclude(x => x.PublishedBy)
    //             .FirstAsync(x => x.Id == CategoryId);
    //
    //         var sortedProductsQuery = OrderBy switch
    //         {
    //             ProductOrder.Name => category.Products.OrderBy(x => x.Name),
    //             ProductOrder.Price => category.Products.OrderBy(x => x.Price),
    //             _ => category.Products.AsEnumerable(),
    //         };
    //
    //         dbProducts = sortedProductsQuery.ToList();
    //     }
    //
    //     ProductList = dbProducts.Select(Map).ToList();
    // }
}
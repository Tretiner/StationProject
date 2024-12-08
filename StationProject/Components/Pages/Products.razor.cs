using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;

namespace StationProject.Components.Pages;

public partial class Products : ComponentBase
{
    public List<Product> ProductList { get; set; } = [];

    protected override async Task OnInitializedAsync()
    {
        ProductList = await _dbContext.Products.OrderBy(x => x.Id).ToListAsync();
    }


    [Inject]
    private ApplicationDbContext _dbContext { get; set; } = null!;
}
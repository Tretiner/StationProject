using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StationProject.Components;
using StationProject.Data.Models;

namespace StationProject.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<KorzinaItem> KorzinaItems { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Category> Category { get; set; } = null!;
    public DbSet<UserActivityMonthStat> UserActivityMonthStats { get; set; } = null!;

    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        AddTimestamps();
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().ToTable("Category")
            .Ignore(e => e.FirstImageUrl);

        ConfigureRelations(modelBuilder);
        CreateDummyModels(modelBuilder);
    }

    private static void ConfigureRelations(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(x => x.Orders)
            .WithOne()
            .HasForeignKey(x => x.OrdererId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(x => x.PublishedProducts)
            .WithOne(x => x.PublishedBy)
            .HasForeignKey(x => x.PublishedByKey)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(x => x.KorzinedItems)
            .WithOne()
            .HasForeignKey(x => x.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>()
            .HasMany(x => x.Products)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryKey)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasMany(x => x.Items)
            .WithOne()
            .HasForeignKey(x => x.OrderKey)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderItem>()
            .HasOne<Product>(x => x.Source)
            .WithOne()
            .HasForeignKey<OrderItem>(x => x.SourceKey)
            .OnDelete(DeleteBehavior.Restrict);
    }

    private static void CreateDummyModels(ModelBuilder modelBuilder)
    {
        var adminUser = new ApplicationUser
        {
            Id = "admin",
            UserName = "admin",
            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
            EmailConfirmed = true,
            Email = "admin@admin.com",
        };

        var vendorUser = new ApplicationUser
        {
            Id = "vendor",
            UserName = "vendor",
            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
            EmailConfirmed = true,
            Email = "vendor@vendor.com",
        };

        var joeUser = new ApplicationUser
        {
            Id = "joe",
            UserName = "joe",
            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
            EmailConfirmed = true,
            Email = "joe@joe.com",
        };

        modelBuilder.Entity<ApplicationUser>().HasData(adminUser, vendorUser, joeUser);


        var adminRole = new IdentityRole { Name = "Admin", NormalizedName = "Admin" };
        var vendorRole = new IdentityRole { Name = "Vendor", NormalizedName = "Vendor" };
        var joeRole = new IdentityRole { Name = "Joe", NormalizedName = "Joe" };
        modelBuilder.Entity<IdentityRole>().HasData(adminRole, vendorRole, joeRole);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = adminRole.Id },
            new IdentityUserRole<string> { UserId = vendorUser.Id, RoleId = vendorRole.Id },
            new IdentityUserRole<string> { UserId = joeUser.Id, RoleId = joeRole.Id }
        );

        var pensCategory = new Category { Name = "Pens", ImageUrls = ["https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK-Vg_IFRtnL2WQsSiJFML7R22xC8i0FL11w&s"] };
        modelBuilder.Entity<Category>().HasData(pensCategory);

        var imageUrls = Array.Empty<string>();
        var products = new[]
        {
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Stapler", Description = "Heavy-duty stapler", Price = 25, PriceTemplate = "$25" },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Notebook", Description = "A5 ruled notebook", Price = 10, PriceTemplate = "$10" },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Pen", Description = "Blue ballpoint pen", Price = 2, PriceTemplate = "$2" },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Pencil", Description = "Graphite pencil", Price = 1, PriceTemplate = "$1" },
            new Product
            {
                PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Highlighter", Description = "Fluorescent highlighter", Price = 3, PriceTemplate = "$3"
            },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Paper Clips", Description = "Box of paper clips", Price = 5, PriceTemplate = "$5" },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Sticky Notes", Description = "Pack of sticky notes", Price = 4, PriceTemplate = "$4" },
            new Product
            {
                PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Whiteboard Marker", Description = "Set of whiteboard markers", Price = 8, PriceTemplate = "$8"
            },
            new Product
            {
                PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Tape Dispenser", Description = "Desktop tape dispenser", Price = 7, PriceTemplate = "$7"
            },
            new Product { PublishedByKey = vendorUser.Id, CategoryKey = pensCategory.Id, ImageUrls = imageUrls, Name = "Scissors", Description = "Stainless steel scissors", Price = 6, PriceTemplate = "$6" }
        };

        modelBuilder.Entity<Product>().HasData(products);
    }

    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x is { Entity: BaseEntity, State: EntityState.Added or EntityState.Modified });

        foreach (var entity in entities)
        {
            var now = DateTime.UtcNow;

            if (entity.State == EntityState.Added)
            {
                ((BaseEntity)entity.Entity).CreatedAt = now;
            }

            ((BaseEntity)entity.Entity).UpdatedAt = now;
        }
    }
}
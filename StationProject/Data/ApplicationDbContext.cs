using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StationProject.Data.Models;

namespace StationProject.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser, ApplicationRole, int>(options)
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<CartItem> Cart { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<UserMonthlyActivityStat> UserActivityMonthStats { get; set; } = null!;

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

        ApplicationDbContextRelations.Setup(modelBuilder);
    }

    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x is { Entity: BaseEntity, State: EntityState.Added or EntityState.Modified });

        foreach (var entity in entities)
        {
            var now = DateTimeOffset.UtcNow;

            if (entity.State == EntityState.Added)
            {
                ((BaseEntity)entity.Entity).CreatedAt = now;
            }

            ((BaseEntity)entity.Entity).UpdatedAt = now;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using StationProject.Data.Models;

namespace StationProject.Data;

public static class ApplicationDbContextRelations
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        // Configure ApplicationUser
        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Language).IsRequired();

            entity.HasMany(u => u.PublishedProducts)
                .WithOne(p => p.Vendor)
                .HasForeignKey(p => p.VendorId)
                .HasPrincipalKey(x => x.Id);

            entity.HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .HasPrincipalKey(x => x.Id);

            entity.HasMany(u => u.CartItems)
                .WithOne(ci => ci.User)
                .HasForeignKey(ci => ci.UserId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure CartItem
        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(ci => ci.Id);
            entity.Property(ci => ci.Count).IsRequired().HasDefaultValue(1);

            entity.HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure Category
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => new { c.Id, c.Language });
            entity.Property(c => c.Name).IsRequired();
            entity.Property(c => c.ImageUrls).IsRequired();

            entity.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure Order
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(o => o.Id);

            entity.HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderKey)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure OrderItem
        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(oi => oi.Id);

            entity.HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure Price
        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(p => new { p.Id, p.Language });

            entity.Property(p => p.Value).IsRequired();

            entity.HasOne(p => p.Template)
                .WithMany()
                .HasForeignKey(p => p.TemplateId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure PriceTemplate
        modelBuilder.Entity<PriceTemplate>(entity =>
        {
            entity.HasKey(pt => new { pt.Id, pt.Language });

            entity.Property(pt => pt.Value).IsRequired();
        });

        // Configure Product
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(p => new { p.Id, p.Language });

            entity.Property(p => p.Name).IsRequired();

            entity.HasOne(p => p.Price)
                .WithMany()
                .HasForeignKey(p => p.PriceId)
                .HasPrincipalKey(x => x.Id);

            entity.HasMany(p => p.Images)
                .WithOne()
                .HasForeignKey(pi => pi.ProductId)
                .HasPrincipalKey(x => x.Id);

            entity.HasOne(x => x.Count)
                .WithMany()
                .HasForeignKey(x => x.CountId)
                .HasPrincipalKey(x => x.Id);
        });

        // Configure ProductCount
        modelBuilder.Entity<ProductCount>(entity =>
        {
            entity.HasKey(pc => pc.Id);
        });

        // Configure ProductImage
        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(pi => pi.Id);
        });

        // Configure ProductStorageInfo
        modelBuilder.Entity<ProductStorageInfo>(entity =>
        {
            entity.HasKey(psi => psi.Id);
        });

        // Configure UserMonthlyActivityStat
        modelBuilder.Entity<UserMonthlyActivityStat>(entity =>
        {
            entity.HasKey(stat => stat.Id);
            entity.Property(stat => stat.TotalSiteViews).IsRequired();
        });
    }
}
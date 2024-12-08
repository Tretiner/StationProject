﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StationProject.Data;

#nullable disable

namespace StationProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9096d211-02e4-4a9e-ba8c-264bc182d166",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "0fcbb53c-a41a-4187-a84e-7d705c9eae8f",
                            Name = "Vendor",
                            NormalizedName = "Vendor"
                        },
                        new
                        {
                            Id = "dd93ac13-65cd-4c87-8041-f946c0a813e0",
                            Name = "Joe",
                            NormalizedName = "Joe"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "admin",
                            RoleId = "9096d211-02e4-4a9e-ba8c-264bc182d166"
                        },
                        new
                        {
                            UserId = "vendor",
                            RoleId = "0fcbb53c-a41a-4187-a84e-7d705c9eae8f"
                        },
                        new
                        {
                            UserId = "joe",
                            RoleId = "dd93ac13-65cd-4c87-8041-f946c0a813e0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StationProject.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "43e5a3bb-60c9-4b2f-a9e2-5967547e3ffe",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7a3392d3-f7fb-406d-97a9-32c469a0e645",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "vendor",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "48ad8f94-eb9d-4776-a0de-1a40d985a6c0",
                            Email = "vendor@vendor.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bce4cfeb-2741-4bad-b786-4143d4d5ada8",
                            TwoFactorEnabled = false,
                            UserName = "vendor"
                        },
                        new
                        {
                            Id = "joe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37a0d191-150f-45a0-9b62-637654740cca",
                            Email = "joe@joe.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMUr0UWwK1X7jOCj6PAlCaCcoQDfYHoo7EcjAYfSj7wRDZnGWCBjVTKFlMSY5rSRgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1bff4795-5731-4f2e-95e2-9568260a6182",
                            TwoFactorEnabled = false,
                            UserName = "joe"
                        });
                });

            modelBuilder.Entity("StationProject.Data.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            ImageUrls = new[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK-Vg_IFRtnL2WQsSiJFML7R22xC8i0FL11w&s" },
                            Name = "Pens"
                        });
                });

            modelBuilder.Entity("StationProject.Data.Models.KorzinaItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("SourceId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("KorzinaItems");
                });

            modelBuilder.Entity("StationProject.Data.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("ArrivalMovedCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("StatusString")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StationProject.Data.Models.OrderItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("ArrivalMovedCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SourceId")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("StatusString")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("StationProject.Data.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CategoryKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string[]>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("MinCount")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("PriceTemplate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("PublishedByKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalCount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryKey");

                    b.HasIndex("PublishedByKey");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "78fd0ee8-9379-42fe-bdcf-f8867ce8dfb8",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Heavy-duty stapler",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Stapler",
                            Price = 25,
                            PriceTemplate = "$25",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "00f18bbf-09cc-41a4-9467-6058f2fd17fa",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "A5 ruled notebook",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Notebook",
                            Price = 10,
                            PriceTemplate = "$10",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "a5ece3b0-017f-4431-9779-209a0c566fd3",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Blue ballpoint pen",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Pen",
                            Price = 2,
                            PriceTemplate = "$2",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "dc42b916-8781-4dbb-acb2-2456edabc164",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Graphite pencil",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Pencil",
                            Price = 1,
                            PriceTemplate = "$1",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "87598589-3329-4e33-8367-cb6d1aedef53",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Fluorescent highlighter",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Highlighter",
                            Price = 3,
                            PriceTemplate = "$3",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "0399a22b-6639-4464-96e8-02a6fbceae55",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Box of paper clips",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Paper Clips",
                            Price = 5,
                            PriceTemplate = "$5",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "b3d9c4a5-449b-4de9-94cc-63c0c8e1d022",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Pack of sticky notes",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Sticky Notes",
                            Price = 4,
                            PriceTemplate = "$4",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "bfcb68b5-74d5-41a4-9bd5-1850ddc83f56",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Set of whiteboard markers",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Whiteboard Marker",
                            Price = 8,
                            PriceTemplate = "$8",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "154cc3f1-6a74-442b-9662-3caeb53c805b",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Desktop tape dispenser",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Tape Dispenser",
                            Price = 7,
                            PriceTemplate = "$7",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        },
                        new
                        {
                            Id = "5b2eea72-5653-40a9-9814-f6a1c8058e7f",
                            CategoryKey = "a2c16485-2cea-41b0-be74-ad678edd0441",
                            Description = "Stainless steel scissors",
                            ImageUrls = new string[0],
                            MinCount = 0,
                            Name = "Scissors",
                            Price = 6,
                            PriceTemplate = "$6",
                            PublishedByKey = "vendor",
                            TotalCount = 0
                        });
                });

            modelBuilder.Entity("StationProject.Data.Models.UserActivityMonthStat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("TotalSiteViews")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("UserActivityMonthStats");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StationProject.Data.Models.KorzinaItem", b =>
                {
                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany("KorzinedItems")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StationProject.Data.Models.Product", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("StationProject.Data.Models.Order", b =>
                {
                    b.HasOne("StationProject.Data.Models.ApplicationUser", null)
                        .WithMany("Orders")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StationProject.Data.Models.OrderItem", b =>
                {
                    b.HasOne("StationProject.Data.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StationProject.Data.Models.Product", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("StationProject.Data.Models.Product", b =>
                {
                    b.HasOne("StationProject.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryKey")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StationProject.Data.Models.ApplicationUser", "PublishedBy")
                        .WithMany("PublishedProducts")
                        .HasForeignKey("PublishedByKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("PublishedBy");
                });

            modelBuilder.Entity("StationProject.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("KorzinedItems");

                    b.Navigation("Orders");

                    b.Navigation("PublishedProducts");
                });

            modelBuilder.Entity("StationProject.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("StationProject.Data.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
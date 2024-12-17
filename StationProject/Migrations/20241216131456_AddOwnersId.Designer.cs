﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StationProject.Data;

#nullable disable

namespace StationProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241216131456_AddOwnersId")]
    partial class AddOwnersId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = "ac8d88c1-fe43-4865-966d-a46bd2a6d593",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "bdb03559-9cf0-4803-8d01-83f0e69534dd",
                            Name = "Vendor",
                            NormalizedName = "Vendor"
                        },
                        new
                        {
                            Id = "be1f572e-318d-4ec5-b97a-2973c0777f92",
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
                            RoleId = "ac8d88c1-fe43-4865-966d-a46bd2a6d593"
                        },
                        new
                        {
                            UserId = "vendor",
                            RoleId = "bdb03559-9cf0-4803-8d01-83f0e69534dd"
                        },
                        new
                        {
                            UserId = "joe",
                            RoleId = "be1f572e-318d-4ec5-b97a-2973c0777f92"
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
                            ConcurrencyStamp = "f180d403-86f1-41d6-9c76-4883025a598a",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fa87f243-9001-440d-8d63-c237b18bf79f",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "vendor",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "77979da3-54c8-45a8-8f7e-26ff90133480",
                            Email = "vendor@vendor.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aaedff85-709c-46f9-890b-da9394127480",
                            TwoFactorEnabled = false,
                            UserName = "vendor"
                        },
                        new
                        {
                            Id = "joe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b74558dd-c98f-493c-a0c8-4481e0bd5026",
                            Email = "joe@joe.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a631ded4-8b9d-45a2-9c85-115267858bd3",
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

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4c28f891-e6a9-47f8-b824-1804c371037f",
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

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SourceId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

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

                    b.Property<string>("OrdererId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("StatusString")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("OrdererId");

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
                            Id = "4644401e-f825-490f-b985-b53325800008",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "7972a853-a8f8-494c-a9a1-ed5450af129f",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "2bed97df-7705-44c2-90f5-a8767c58c717",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "31c6ac98-f295-4015-815d-fa4add3baab6",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "395f41df-6710-4717-9f0b-6006685a5b6a",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "3612eaf7-c873-489a-83d0-ffde771b537c",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "d2136b1a-5114-4734-a69b-a3ea0356ba07",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "556663f6-af29-471e-8f6c-1c773b22b24b",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "a93a67d3-2759-499f-a7b8-6fc4ad0d6a1d",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                            Id = "6a4406ce-eaaf-40c2-aa74-3604732fca02",
                            CategoryKey = "4c28f891-e6a9-47f8-b824-1804c371037f",
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
                        .HasForeignKey("OwnerId")
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
                        .HasForeignKey("OrdererId")
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
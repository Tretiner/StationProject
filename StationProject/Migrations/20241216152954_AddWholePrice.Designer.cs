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
    [Migration("20241216152954_AddWholePrice")]
    partial class AddWholePrice
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
                            Id = "2561de22-e064-4464-8dc8-83e7587e1e03",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "f1c1d1be-dd79-47cf-95a0-c16ae98d8917",
                            Name = "Vendor",
                            NormalizedName = "Vendor"
                        },
                        new
                        {
                            Id = "a4d2047e-e2f6-46a0-8cbe-34cad22275ec",
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
                            RoleId = "2561de22-e064-4464-8dc8-83e7587e1e03"
                        },
                        new
                        {
                            UserId = "vendor",
                            RoleId = "f1c1d1be-dd79-47cf-95a0-c16ae98d8917"
                        },
                        new
                        {
                            UserId = "joe",
                            RoleId = "a4d2047e-e2f6-46a0-8cbe-34cad22275ec"
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
                            ConcurrencyStamp = "5f5711ad-b8e5-4de0-b19a-26184396a365",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ce50faff-9649-47be-8129-7f999c79423b",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "vendor",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "648d67d5-9840-470d-b262-272673b1643d",
                            Email = "vendor@vendor.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6ef52eae-acfc-4139-b5d7-ead45f7065ff",
                            TwoFactorEnabled = false,
                            UserName = "vendor"
                        },
                        new
                        {
                            Id = "joe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad1a8cc7-487f-4bf0-9efc-2207044372a5",
                            Email = "joe@joe.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELP3+rBC8vA/imJVeDAnth3KTzInFeD78Ftk7pJAlsaXddxLo8toEvzoWpPyYz07Pw====",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b97ee632-2176-4640-b857-735abb201d5c",
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
                            Id = "084c844d-9b87-423e-991e-8849eb961115",
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

                    b.Property<string>("WholeCost")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

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
                            Id = "fe5ab14d-11bc-4cc3-8f6b-0291360740be",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "3d5c143b-a906-414c-8558-ce19d6145b81",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "c05a1ca9-8c99-401c-96ec-9618769aba38",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "c65775da-4242-46d3-9565-98cd67f30480",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "39eb16ec-7b60-4a8d-ae1a-073d21ee6786",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "2e4a76c7-ec3b-4f91-acf9-d47a4a46209e",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "70daca21-0432-473a-8389-f30c29647790",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "1214e94f-5320-43cd-bee3-4056f5f1faa4",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "0a17fa70-b71e-4566-a7f2-ca4af71c5833",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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
                            Id = "07f0969a-c3e2-42db-aa08-7475a3d3b3a7",
                            CategoryKey = "084c844d-9b87-423e-991e-8849eb961115",
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

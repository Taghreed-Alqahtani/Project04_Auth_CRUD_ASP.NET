﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pets_Houses.Data;

namespace Pets_Houses.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Pets_Houses.Models.CartModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Pets_Houses.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date_Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pets_Houses.Models.Orders_ProductsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders_Products");
                });

            modelBuilder.Entity("Pets_Houses.Models.PetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNo")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Pets_Houses.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/1a0a7e95-de58-40c8-bb0e-811668f82b92.jpg",
                            Price = 10f,
                            ProductName = "Vitakraft Cat Stick Mini Duck and Rabbit",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Weight: 1.4kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/30f89668-6e1e-4691-bf5f-65c51a88fc53.jpg",
                            Price = 40f,
                            ProductName = "Burgess Old Cat Food with Turkey & Berries",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/881b50e2-5d84-46aa-b747-e0a12cb75bd0.png",
                            Price = 10f,
                            ProductName = "I17 Nutram Ideal Solution Support Indoor Cat Canned Food",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/000b5181-c161-4ccb-aa39-b1f8fce5c4d3.png",
                            Price = 7f,
                            ProductName = "S1 Nutram Sound Blaanced Wellness Kitten Canned Food",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/c3c88b68-374a-4324-9902-4b4d079d8c60.jpg",
                            Price = 8f,
                            ProductName = "Vitakraft Cat Yums Liver Sausage",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/3efd1f79-358e-431f-9700-9cd20dec2af2.jpg",
                            Price = 20f,
                            ProductName = "GimCat Skin & Coat Tabs Beauty Complex",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/39470729-761d-4efe-8eb0-9748d409cec3.png",
                            Price = 8f,
                            ProductName = "Vitakraft Cat Yums Chicken and Cat Grass",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/84651856-a067-475c-aa0b-9365840f9877.jpg",
                            Price = 14f,
                            ProductName = "GimCat Latte Milk Low in Lactose, 200ml",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Weight : 3Kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/c7949b39-af12-4ab4-a877-8872339f4443.jpg",
                            Price = 48f,
                            ProductName = "Brit Dog Dry Food Sensitive Lamb",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Weight : 8Kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/ad295124-4190-472c-99d2-b3d4b4a5a7f6.jpg",
                            Price = 120f,
                            ProductName = "Brit Dog Dry Food Junior S Chicken",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Weight : 3Kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/962bf854-0225-4cf4-aca1-63acdb61193e.jpg",
                            Price = 50f,
                            ProductName = "Brit Dog Dry Food Adult M Chicken",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Weight : 3Kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/ef59e7b5-0d71-4f00-8a63-50e3d05ece52.jpg",
                            Price = 54f,
                            ProductName = "Brit Puppy Dry Food Lamb&Rice ",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Weight : 1Kg",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/d70fc4c6-6a26-403f-8e46-f1f207e5c742.jpg",
                            Price = 30f,
                            ProductName = "Brit Dog Dry Food Champion Salmon",
                            Type = "Food"
                        },
                        new
                        {
                            Id = 14,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/553f21d9-01de-4160-9359-c3fd18a4a20f.png",
                            Price = 17f,
                            ProductName = "Playing rod with bird With catnip",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 15,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/b1108e16-7231-4f54-9a56-bf38d03ead8e.png",
                            Price = 88f,
                            ProductName = "Playing tunnel fleece colourful 25×50 cm",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 16,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/b2dfb935-a807-4437-9b80-87c5c66d7b5d.png",
                            Price = 17f,
                            ProductName = "Owl Toy With Catnip",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 17,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/bdfeabe4-89ff-4870-8d5e-f1f4c437b7c4.png",
                            Price = 29f,
                            ProductName = "Playing Rod For Cats",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 18,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/f576c5a4-01c6-4ad9-92fd-33d7bdf39739.jpg",
                            Price = 7f,
                            ProductName = "Playing Rope 20 cm",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 19,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/fcb3def2-b06e-458d-8a44-f31b2ed5a2d4.png",
                            Price = 17f,
                            ProductName = "Playing rope with woven in ball",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 20,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/12bac90a-0e58-4b89-b33a-ae15a564e81f.png",
                            Price = 19f,
                            ProductName = "Dumbbell For Play 19 cm",
                            Type = "Toy"
                        },
                        new
                        {
                            Id = 21,
                            Description = "",
                            Image = "https://media.zid.store/109d86f9-1e54-40fe-976d-410787c33436/994397bc-6668-4823-adee-ae6ec1f3d43f.jpeg",
                            Price = 30f,
                            ProductName = "BE NORDIC whale Brunold, plush, 25 cm",
                            Type = "Toy"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pets_Houses.Models.CartModel", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pets_Houses.Models.OrderModel", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pets_Houses.Models.Orders_ProductsModel", b =>
                {
                    b.HasOne("Pets_Houses.Models.OrderModel", "Order")
                        .WithMany("Order_Product")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pets_Houses.Models.ProductModel", "Product")
                        .WithMany("Order_Product")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Pets_Houses.Models.PetModel", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pets_Houses.Models.OrderModel", b =>
                {
                    b.Navigation("Order_Product");
                });

            modelBuilder.Entity("Pets_Houses.Models.ProductModel", b =>
                {
                    b.Navigation("Order_Product");
                });
#pragma warning restore 612, 618
        }
    }
}

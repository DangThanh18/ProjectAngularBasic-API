﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectAPI;

#nullable disable

namespace ProjectAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectAPI.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ManufacturerID"));

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ManufacturerID");

                    b.ToTable("Manufacturers", (string)null);

                    b.HasData(
                        new
                        {
                            ManufacturerID = 1,
                            ManufacturerName = "Iphone"
                        },
                        new
                        {
                            ManufacturerID = 2,
                            ManufacturerName = "Oppo"
                        },
                        new
                        {
                            ManufacturerID = 3,
                            ManufacturerName = "Samsung"
                        });
                });

            modelBuilder.Entity("ProjectAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("ProjectAPI.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("integer");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductID")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<long>("SubTotal")
                        .HasColumnType("bigint");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("ProjectAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductID"));

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("integer");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<string>("Specifications")
                        .HasColumnType("text");

                    b.HasKey("ProductID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            ManufacturerID = 1,
                            Price = 9990000L,
                            ProductName = "Iphone 11",
                            Specifications = "LCD 6.1 inch, 150.9 x 75.7 x 8.3mm, Apple A13 Bionic, Ram 4GB, 64GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3110mAh, 18W, đen"
                        },
                        new
                        {
                            ProductID = 2,
                            ManufacturerID = 1,
                            Price = 31990000L,
                            ProductName = "Iphone 15 pro max",
                            Specifications = "OLED, 6.7, Super Retina XDR, Apple A17 Pro 6 nhân, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 4422mAh, 20W, titan tự nhiên"
                        },
                        new
                        {
                            ProductID = 3,
                            ManufacturerID = 3,
                            Price = 22990000L,
                            ProductName = "Samsung s23 Ultra",
                            Specifications = "Dynamic AMOLED 2X 6.8 Quad HD+ (2K+), Snapdragon 8 Gen 2, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 45W, kem"
                        },
                        new
                        {
                            ProductID = 4,
                            ManufacturerID = 3,
                            Price = 18990000L,
                            ProductName = "Samsung z flip 5",
                            Specifications = "Chính: Dynamic AMOLED 2X, Phụ: Super AMOLED, Chính 6.7 & Phụ 3.4, Full HD+, Snapdragon 8 Gen 2, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 3700mAh, 25W, tím nhạt"
                        },
                        new
                        {
                            ProductID = 5,
                            ManufacturerID = 2,
                            Price = 4490000L,
                            ProductName = "Oppo A38 6GB",
                            Specifications = "IPS LCD, 6.56, HD+, MediaTek Helio G85, Ram 6GB, 128GB, 2 Nano SIM, Hỗ trợ 4G, 5000mAh, 33W, vàng đồng"
                        },
                        new
                        {
                            ProductID = 6,
                            ManufacturerID = 2,
                            Price = 10990000L,
                            ProductName = "Oppo Reno11 5G",
                            Specifications = "AMOLED 6.7 Full HD+, MediaTek Dimensity 7050 5G 8 nhân, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 67W, xanh ngọc"
                        },
                        new
                        {
                            ProductID = 7,
                            ManufacturerID = 1,
                            Price = 25190000L,
                            ProductName = "Iphone 14 pro",
                            Specifications = "OLED, 6.1, 206gram, A16 Bionic, Ram 6GB, 128GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3200mAh, 20W, vàng"
                        },
                        new
                        {
                            ProductID = 8,
                            ManufacturerID = 3,
                            Price = 5290000L,
                            ProductName = "Samsung Galaxy A15",
                            Specifications = "Super AMOLED6.5 Full HD+, MediaTek Helio G99, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 4G, 5000 mAh, 25W, xanh dương nhạt"
                        });
                });

            modelBuilder.Entity("ProjectAPI.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "admin@gmail.com",
                            Gender = "Male",
                            PassWord = "admin123",
                            PhoneNumber = "1234567890",
                            UserName = "Admin",
                            UserType = "Admin"
                        });
                });

            modelBuilder.Entity("ProjectAPI.Models.Order", b =>
                {
                    b.HasOne("ProjectAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectAPI.Models.OrderDetail", b =>
                {
                    b.HasOne("ProjectAPI.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProjectAPI.Models.Product", b =>
                {
                    b.HasOne("ProjectAPI.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });
#pragma warning restore 612, 618
        }
    }
}

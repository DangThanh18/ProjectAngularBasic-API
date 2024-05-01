using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                UserID = 1,
                UserName = "Admin",
                PassWord = "admin123",
                Email = "admin@gmail.com",
                PhoneNumber = "1234567890",
                Gender = "Male",
                UserType = UserType.Admin
            });

            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer() { ManufacturerID = 1, ManufacturerName = "Iphone"},
                new Manufacturer() { ManufacturerID = 2, ManufacturerName = "Oppo"},
                new Manufacturer() { ManufacturerID = 3, ManufacturerName = "Samsung"});

            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductID = 1, ProductName = "Iphone 11", ManufacturerID = 1, Price = 9990000, Specifications = "LCD 6.1 inch, 150.9 x 75.7 x 8.3mm, Apple A13 Bionic, Ram 4GB, 64GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3110mAh, 18W, đen" },
                new Product() { ProductID = 2, ProductName = "Iphone 15 pro max", ManufacturerID = 1, Price = 31990000, Specifications = "OLED, 6.7, Super Retina XDR, Apple A17 Pro 6 nhân, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 4422mAh, 20W, titan tự nhiên" },
                new Product() { ProductID = 3, ProductName = "Samsung s23 Ultra", ManufacturerID = 3, Price = 22990000, Specifications = "Dynamic AMOLED 2X 6.8 Quad HD+ (2K+), Snapdragon 8 Gen 2, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 45W, kem" },
                new Product() { ProductID = 4, ProductName = "Samsung z flip 5", ManufacturerID = 3, Price = 18990000, Specifications = "Chính: Dynamic AMOLED 2X, Phụ: Super AMOLED, Chính 6.7 & Phụ 3.4, Full HD+, Snapdragon 8 Gen 2, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 3700mAh, 25W, tím nhạt" },
                new Product() { ProductID = 5, ProductName = "Oppo A38 6GB", ManufacturerID = 2, Price = 4490000, Specifications = "IPS LCD, 6.56, HD+, MediaTek Helio G85, Ram 6GB, 128GB, 2 Nano SIM, Hỗ trợ 4G, 5000mAh, 33W, vàng đồng" },
                new Product() { ProductID = 6, ProductName = "Oppo Reno11 5G", ManufacturerID = 2, Price = 10990000, Specifications = "AMOLED 6.7 Full HD+, MediaTek Dimensity 7050 5G 8 nhân, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 67W, xanh ngọc" },
                new Product() { ProductID = 7, ProductName = "Iphone 14 pro", ManufacturerID = 1, Price = 25190000, Specifications = "OLED, 6.1, 206gram, A16 Bionic, Ram 6GB, 128GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3200mAh, 20W, vàng" },
                new Product() { ProductID = 8, ProductName = "Samsung Galaxy A15", ManufacturerID = 3, Price = 5290000, Specifications = "Super AMOLED6.5 Full HD+, MediaTek Helio G99, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 4G, 5000 mAh, 25W, xanh dương nhạt" });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<UserType>().HaveConversion<string>();
        }
    }
}

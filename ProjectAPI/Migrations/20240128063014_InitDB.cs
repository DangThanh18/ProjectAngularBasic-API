using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ManufacturerName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PassWord = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    ManufacturerID = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Specifications = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderID = table.Column<int>(type: "integer", nullable: false),
                    ProductID = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    SubTotal = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerID", "ManufacturerName" },
                values: new object[,]
                {
                    { 1, "Iphone" },
                    { 2, "Oppo" },
                    { 3, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Gender", "PassWord", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { 1, "admin@gmail.com", "Male", "admin123", "1234567890", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ManufacturerID", "Price", "ProductName", "Specifications" },
                values: new object[,]
                {
                    { 1, 1, 9990000L, "Iphone 11", "LCD 6.1 inch, 150.9 x 75.7 x 8.3mm, Apple A13 Bionic, Ram 4GB, 64GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3110mAh, 18W, đen" },
                    { 2, 1, 31990000L, "Iphone 15 pro max", "OLED, 6.7, Super Retina XDR, Apple A17 Pro 6 nhân, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 4422mAh, 20W, titan tự nhiên" },
                    { 3, 3, 22990000L, "Samsung s23 Ultra", "Dynamic AMOLED 2X 6.8 Quad HD+ (2K+), Snapdragon 8 Gen 2, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 45W, kem" },
                    { 4, 3, 18990000L, "Samsung z flip 5", "Chính: Dynamic AMOLED 2X, Phụ: Super AMOLED, Chính 6.7 & Phụ 3.4, Full HD+, Snapdragon 8 Gen 2, Ram 8GB, 256GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 5G, 3700mAh, 25W, tím nhạt" },
                    { 5, 2, 4490000L, "Oppo A38 6GB", "IPS LCD, 6.56, HD+, MediaTek Helio G85, Ram 6GB, 128GB, 2 Nano SIM, Hỗ trợ 4G, 5000mAh, 33W, vàng đồng" },
                    { 6, 2, 10990000L, "Oppo Reno11 5G", "AMOLED 6.7 Full HD+, MediaTek Dimensity 7050 5G 8 nhân, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 5G, 5000mAh, 67W, xanh ngọc" },
                    { 7, 1, 25190000L, "Iphone 14 pro", "OLED, 6.1, 206gram, A16 Bionic, Ram 6GB, 128GB, 1 Nano SIM & 1 eSIM, Hỗ trợ 4G, 3200mAh, 20W, vàng" },
                    { 8, 3, 5290000L, "Samsung Galaxy A15", "Super AMOLED6.5 Full HD+, MediaTek Helio G99, Ram 8GB, 256GB, 2 Nano SIM, Hỗ trợ 4G, 5000 mAh, 25W, xanh dương nhạt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerID",
                table: "Products",
                column: "ManufacturerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}

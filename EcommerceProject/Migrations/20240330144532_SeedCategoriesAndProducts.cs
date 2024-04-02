using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Desktops", "desktops" },
                    { 2, "Laptops", "laptops" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, 1, "Intel Core i7-14700KF, 32GB DDR5, 1TB SSD M.2 2280 PCIe NVMe, NVIDIA® GeForce® RTX4070, Windows 11 Home", "ASUS1.jpg", "ASUS G22 G22CH", 69990.00m, "asus g22 g22ch" },
                    { 2, 1, "Intel Core i7-14700F, 16GB DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 3050 8GB GDDR6, Windows 11 Home + Office Home & Student 2021", "INSPIRON1.jpg", "DELL INSPIRON3030MT", 41990.00m, "dell inspiron3030mt" },
                    { 3, 1, "Intel Core i7-14700, 16GB (8GB x2) DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 4060  8GB GDDR6, Windows 11 Home + Office Home & Student 2021", "XPS1.jpg", "DELL XPS8960", 67990.00m, "dell xps8960" },
                    { 4, 2, "Intel Core i9-14900HX, 32GB (16GBx2) DDR5, 1TB PCIe/NVMe M.2 SSD, 16\" WQXGA IPS 250Hz, Nvidia GeForce RTX 4080 12 GB GDDR6, Windows 11 Home", "HELIOS1.jpg", "ACER PREDATOR HELIOS 16", 99990.00m, "acer predator helios 16" },
                    { 5, 2, "AMD Ryzen 9 8945H, 16GB DDR5 5600MHz, 1TB PCIe/NVMe M.2 SSD, 15.6\" Full HD IPS Anti-glare 144Hz, Nvidia GeForce RTX 4060 8 GB GDDR6, Windows 11 Home", "TUF1.jpg", "ASUS TUF GAMING A15", 45990.00m, "asus tuf gameing a15" },
                    { 6, 2, "AMD Ryzen 5 7520U, 8GB LPDDR5 (ON BOARD), 512GB PCIe/NVMe M.2 SSD, 15.6\" FHD Anti-Glare, AMD Radeon Graphics (Integrated), Windows 11 Home", "Go1.jpg", "ASUS Vivobook Go 15", 14990.00m, "asus vivobook go 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

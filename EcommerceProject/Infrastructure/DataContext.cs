using EcommerceProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Infrastructure
{
    public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext (options)
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Desktops", Slug = "desktops"},
                new Category { Id = 2, Name = "Laptops", Slug = "laptops" }
           );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "ASUS G22 G22CH",
                    Slug = "asus g22 g22ch",
                    Description = "Intel Core i7-14700KF, 32GB DDR5, 1TB SSD M.2 2280 PCIe NVMe, NVIDIA® GeForce® RTX4070, Windows 11 Home",
                    Price = 69990.00M,
                    CategoryId = 1,
                    Image = "ASUS1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "DELL INSPIRON3030MT",
                    Slug = "dell inspiron3030mt",
                    Description = "Intel Core i7-14700F, 16GB DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 3050 8GB GDDR6, Windows 11 Home + Office Home & Student 2021",
                    Price = 41990.00M,
                    CategoryId = 1,
                    Image = "INSPIRON1.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "DELL XPS8960",
                    Slug = "dell xps8960",
                    Description = "Intel Core i7-14700, 16GB (8GB x2) DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 4060  8GB GDDR6, Windows 11 Home + Office Home & Student 2021",
                    Price = 67990.00M,
                    CategoryId = 1,
                    Image = "XPS1.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "ACER PREDATOR HELIOS 16",
                    Slug = "acer predator helios 16",
                    Description = "Intel Core i9-14900HX, 32GB (16GBx2) DDR5, 1TB PCIe/NVMe M.2 SSD, 16\" WQXGA IPS 250Hz, Nvidia GeForce RTX 4080 12 GB GDDR6, Windows 11 Home",
                    Price = 99990.00M,
                    CategoryId = 2,
                    Image = "HELIOS1.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "ASUS TUF GAMING A15",
                    Slug = "asus tuf gameing a15",
                    Description = "AMD Ryzen 9 8945H, 16GB DDR5 5600MHz, 1TB PCIe/NVMe M.2 SSD, 15.6\" Full HD IPS Anti-glare 144Hz, Nvidia GeForce RTX 4060 8 GB GDDR6, Windows 11 Home",
                    Price = 45990.00M,
                    CategoryId = 2,
                    Image = "TUF1.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "ASUS Vivobook Go 15",
                    Slug = "asus vivobook go 15",
                    Description = "AMD Ryzen 5 7520U, 8GB LPDDR5 (ON BOARD), 512GB PCIe/NVMe M.2 SSD, 15.6\" FHD Anti-Glare, AMD Radeon Graphics (Integrated), Windows 11 Home",
                    Price = 14990.00M,
                    CategoryId = 2,
                    Image = "Go1.jpg"
                }
            );

            modelBuilder.Entity<Page>().HasData(
                    new Page { Id = 1, Title = "Home", Slug = "home", Body = "This is the home page" },
                    new Page { Id = 2, Title = "About", Slug = "about", Body = "This is the about page" },
                    new Page { Id = 3, Title = "Services", Slug = "services", Body = "This is the services page" },
                    new Page { Id = 4, Title = "Contact", Slug = "contact", Body = "This is the contact page" }
                );
        }
        public DbSet<EcommerceProject.Models.User> User { get; set; }
    }
}

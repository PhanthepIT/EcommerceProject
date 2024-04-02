﻿// <auto-generated />
using EcommerceProject.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240330144532_SeedCategoriesAndProducts")]
    partial class SeedCategoriesAndProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desktops",
                            Slug = "desktops"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptops",
                            Slug = "laptops"
                        });
                });

            modelBuilder.Entity("EcommerceProject.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is the home page",
                            Order = 100,
                            Slug = "home",
                            Title = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Body = "This is the about page",
                            Order = 100,
                            Slug = "about",
                            Title = "About"
                        },
                        new
                        {
                            Id = 3,
                            Body = "This is the services page",
                            Order = 100,
                            Slug = "services",
                            Title = "Services"
                        },
                        new
                        {
                            Id = 4,
                            Body = "This is the contact page",
                            Order = 100,
                            Slug = "contact",
                            Title = "Contact"
                        });
                });

            modelBuilder.Entity("EcommerceProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Intel Core i7-14700KF, 32GB DDR5, 1TB SSD M.2 2280 PCIe NVMe, NVIDIA® GeForce® RTX4070, Windows 11 Home",
                            Image = "ASUS1.jpg",
                            Name = "ASUS G22 G22CH",
                            Price = 69990.00m,
                            Slug = "asus g22 g22ch"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Intel Core i7-14700F, 16GB DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 3050 8GB GDDR6, Windows 11 Home + Office Home & Student 2021",
                            Image = "INSPIRON1.jpg",
                            Name = "DELL INSPIRON3030MT",
                            Price = 41990.00m,
                            Slug = "dell inspiron3030mt"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Intel Core i7-14700, 16GB (8GB x2) DDR5 5600, 1TB SSD M.2 PCIe NVMe, NVIDIA® GeForce RTX™ 4060  8GB GDDR6, Windows 11 Home + Office Home & Student 2021",
                            Image = "XPS1.jpg",
                            Name = "DELL XPS8960",
                            Price = 67990.00m,
                            Slug = "dell xps8960"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Intel Core i9-14900HX, 32GB (16GBx2) DDR5, 1TB PCIe/NVMe M.2 SSD, 16\" WQXGA IPS 250Hz, Nvidia GeForce RTX 4080 12 GB GDDR6, Windows 11 Home",
                            Image = "HELIOS1.jpg",
                            Name = "ACER PREDATOR HELIOS 16",
                            Price = 99990.00m,
                            Slug = "acer predator helios 16"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "AMD Ryzen 9 8945H, 16GB DDR5 5600MHz, 1TB PCIe/NVMe M.2 SSD, 15.6\" Full HD IPS Anti-glare 144Hz, Nvidia GeForce RTX 4060 8 GB GDDR6, Windows 11 Home",
                            Image = "TUF1.jpg",
                            Name = "ASUS TUF GAMING A15",
                            Price = 45990.00m,
                            Slug = "asus tuf gameing a15"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "AMD Ryzen 5 7520U, 8GB LPDDR5 (ON BOARD), 512GB PCIe/NVMe M.2 SSD, 15.6\" FHD Anti-Glare, AMD Radeon Graphics (Integrated), Windows 11 Home",
                            Image = "Go1.jpg",
                            Name = "ASUS Vivobook Go 15",
                            Price = 14990.00m,
                            Slug = "asus vivobook go 15"
                        });
                });

            modelBuilder.Entity("EcommerceProject.Models.Product", b =>
                {
                    b.HasOne("EcommerceProject.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

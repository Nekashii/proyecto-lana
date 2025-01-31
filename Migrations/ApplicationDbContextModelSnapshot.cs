﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store;

#nullable disable

namespace Store.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Store.Models.CartProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Store.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Store.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1023)
                        .HasColumnType("nvarchar(1023)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 10,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1329),
                            Description = "Jeje",
                            Image = "https://http2.mlstatic.com/D_NQ_NP_636771-MLM78569019015_082024-O.webp",
                            Name = "Diviltac",
                            Price = 49.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 4,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1343),
                            Description = "Botas de piel",
                            Image = "https://prada.mx/cdn/shop/files/82001113BO4NEGTC.jpg?v=1722530022",
                            Name = "Botas",
                            Price = 400.0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 0,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1358),
                            Description = "Sandalias de Verano",
                            Image = "https://i.pinimg.com/564x/36/44/cb/3644cbc16a8dd7b678fb8fcf18880893.jpg",
                            Name = "Sandalias",
                            Price = 350.0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 2,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1372),
                            Description = "Zapatillas con tacon",
                            Image = "https://grecoshoes.mx/cdn/shop/files/FB_IMG_1709660586119.jpg?v=1718479176",
                            Name = "zapatillas",
                            Price = 500.0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 5,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1382),
                            Description = "Uso del que quieras",
                            Image = "https://armystorepuebla.com.mx/wp-content/uploads/2024/02/1-Pagina-1.png",
                            Name = "Maquina de guerra",
                            Price = 500.0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 9999,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1397),
                            Description = "Perfectas para patear abuelitas ",
                            Image = "https://m.media-amazon.com/images/I/61z7ObMv60L._AC_SY695_.jpg",
                            Name = "Patea Abuelitas",
                            Price = 99999.0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 0,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1411),
                            Description = "Rompe Huevos de Gallina y mas ",
                            Image = "https://img.kwcdn.com/product/Fancyalgo/VirtualModelMatting/71681cd722ec5bb372b77fd5cd8923e7.jpg?imageView2/2/w/800/q/70/format/webp",
                            Name = "Rompe Huevos",
                            Price = 999.0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 3,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1425),
                            Description = "Perfectos para Luz ",
                            Image = "https://m.media-amazon.com/images/I/51KcqFWBdhL._AC_SY695_.jpg",
                            Name = "Tacones de Puta",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 9999,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1439),
                            Description = "Zapatos para ganar sueldo minimo y trabar como burro de carga",
                            Image = "https://media.gotrendier.mx/media/p/2022/02/07/n_62656cf8-8848-11ec-8091-026295ecb39b.jpeg",
                            Name = "Zapatos de godin",
                            Price = 150.0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 1,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1448),
                            Description = "Zapatillas que utilizaria peso pluma si fuera trans",
                            Image = "https://conideade.com/blog/wp-content/uploads/2014/08/zapato-decorado-con-pluma.jpg",
                            Name = "Zapatillas de plumas",
                            Price = 999999.0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 4,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1467),
                            Description = "Botas altotas rosas",
                            Image = "https://m.media-amazon.com/images/I/410gwyM1sFL._AC_SY695_.jpg",
                            Name = "Alv que es esto",
                            Price = 999.0
                        });
                });

            modelBuilder.Entity("Store.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Admin = true,
                            CreatedAt = new DateTime(2024, 12, 1, 22, 30, 1, 453, DateTimeKind.Local).AddTicks(1170),
                            Email = "alitzel@gmail.com",
                            FirstName = "Alitzel",
                            LastName = "C",
                            Password = "Cisco123"
                        });
                });

            modelBuilder.Entity("Store.Models.CartProduct", b =>
                {
                    b.HasOne("Store.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store.Models.Order", b =>
                {
                    b.HasOne("Store.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Store.Models.OrderProduct", b =>
                {
                    b.HasOne("Store.Models.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.HasOne("Store.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store.Models.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

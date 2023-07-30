﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    partial class InventaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "ASH",
                            CategoryName = "Aseo Hogar"
                        },
                        new
                        {
                            CategoryId = "ASP",
                            CategoryName = "Aseo Personal"
                        },
                        new
                        {
                            CategoryId = "HGR",
                            CategoryName = "Hogar"
                        },
                        new
                        {
                            CategoryId = "PRF",
                            CategoryName = "Perfumeria"
                        },
                        new
                        {
                            CategoryId = "SLD",
                            CategoryName = "Salud"
                        },
                        new
                        {
                            CategoryId = "VDJ",
                            CategoryName = "Video Juegos"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.Property<string>("InputOutputId")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<DateTime>("InputOutputDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("IsInput")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("Quantity")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("InputOutputId");

                    b.ToTable("InOuts");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("NVARCHAR2(600)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<DateTime>("StorageUpdate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("WarehouseAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = "23e85213-3212-4db7-bf96-1e30b85e7b65",
                            WarehouseAddress = "calle 26 con 60",
                            WarehouseName = "Bodega Central"
                        },
                        new
                        {
                            WarehouseId = "d2f2e4c1-1e2b-4ce7-a89e-739785672f31",
                            WarehouseAddress = "calle 40 sur con 80",
                            WarehouseName = "Bodega sur"
                        },
                        new
                        {
                            WarehouseId = "456c3281-c9c6-4037-aaf9-b728100fcf27",
                            WarehouseAddress = "calle 127 sur con 45",
                            WarehouseName = "Bodega norte"
                        });
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Navigation("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}

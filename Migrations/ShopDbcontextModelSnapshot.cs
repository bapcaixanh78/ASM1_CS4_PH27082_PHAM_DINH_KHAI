﻿// <auto-generated />
using System;
using ASM1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM1.Migrations
{
    [DbContext(typeof(ShopDbcontext))]
    partial class ShopDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASM1.Models.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("SupplierIdSupplier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMaterial");

                    b.HasIndex("SupplierIdSupplier");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ASM1.Models.Supplier", b =>
                {
                    b.Property<Guid>("IdSupplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdSupplier");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ASM1.Models.Material", b =>
                {
                    b.HasOne("ASM1.Models.Supplier", "Supplier")
                        .WithMany("Materials")
                        .HasForeignKey("SupplierIdSupplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ASM1.Models.Supplier", b =>
                {
                    b.Navigation("Materials");
                });
#pragma warning restore 612, 618
        }
    }
}

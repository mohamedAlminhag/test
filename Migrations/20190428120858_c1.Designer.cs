﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test.Data;

namespace test.Migrations
{
    [DbContext(typeof(MISDbContext))]
    [Migration("20190428120858_c1")]
    partial class c1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("test.Models.Cart", b =>
                {
                    b.Property<int>("cartId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("createdDate");

                    b.HasKey("cartId");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("test.Models.CartItem", b =>
                {
                    b.Property<int>("cartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cartId");

                    b.Property<string>("productId");

                    b.Property<double>("productPrice");

                    b.Property<int>("productQty");

                    b.HasKey("cartItemId");

                    b.HasIndex("cartId");

                    b.ToTable("cartItems");
                });

            modelBuilder.Entity("test.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("createdDate");

                    b.Property<string>("productName")
                        .HasMaxLength(5);

                    b.Property<double>("productPrice");

                    b.Property<int>("productQty");

                    b.HasKey("productId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("test.Models.CartItem", b =>
                {
                    b.HasOne("test.Models.Cart")
                        .WithMany("cartItems")
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
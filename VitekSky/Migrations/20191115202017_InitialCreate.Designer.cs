﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VitekSky.Data;

namespace VitekSky.Migrations
{
    [DbContext(typeof(BusinessContext))]
    [Migration("20191115202017_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VitekSky.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("SubscriptionDate");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VitekSky.Models.Product", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("Price");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50);

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("VitekSky.Models.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<int?>("CustomerLoyalty");

                    b.Property<int>("ProductID");

                    b.HasKey("SubscriptionID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("VitekSky.Models.Subscription", b =>
                {
                    b.HasOne("VitekSky.Models.Customer", "Customer")
                        .WithMany("Subscriptions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VitekSky.Models.Product", "Product")
                        .WithMany("Subscriptions")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

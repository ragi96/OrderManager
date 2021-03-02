﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Data.Context;

namespace OrderManagement.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210302103159_SeedTemporalTestThirdPart")]
    partial class SeedTemporalTestThirdPart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderManagement.Data.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleGroupId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<double>("Mwst")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ArticleGroupId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.ArticleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperiorArticleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperiorArticleId");

                    b.ToTable("ArticleGroup");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.ArticleGroupView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperiorArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("TreeLevel")
                        .HasColumnType("int");

                    b.Property<string>("TreePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArticleGroupView");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<double>("ArticlePrice")
                        .HasColumnType("float");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("OrderId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Article", b =>
                {
                    b.HasOne("OrderManagement.Data.Model.ArticleGroup", "ArticleGroup")
                        .WithMany()
                        .HasForeignKey("ArticleGroupId");

                    b.Navigation("ArticleGroup");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.ArticleGroup", b =>
                {
                    b.HasOne("OrderManagement.Data.Model.ArticleGroup", "SuperiorArticleGroup")
                        .WithMany()
                        .HasForeignKey("SuperiorArticleId");

                    b.Navigation("SuperiorArticleGroup");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Order", b =>
                {
                    b.HasOne("OrderManagement.Data.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Position", b =>
                {
                    b.HasOne("OrderManagement.Data.Model.Article", "Article")
                        .WithMany("Positions")
                        .HasForeignKey("ArticleId");

                    b.HasOne("OrderManagement.Data.Model.Order", "Order")
                        .WithMany("Positions")
                        .HasForeignKey("OrderId");

                    b.Navigation("Article");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Article", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OrderManagement.Data.Model.Order", b =>
                {
                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}

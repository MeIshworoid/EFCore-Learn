﻿// <auto-generated />
using System;
using EFCoreLearn.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreLearn.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreLearn.Models.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("GenreId"));

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ActionTaken")
                        .HasColumnType("int");

                    b.Property<string>("ActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("EFCoreLearn.Models.Models.Movie", b =>
                {
                    b.Property<long>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MovieId"));

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ActionTaken")
                        .HasColumnType("int");

                    b.Property<string>("ActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1L,
                            ActionDate = new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3536),
                            ActionTaken = 1,
                            ActionType = "Create",
                            Genre = "Adventure, Action, Fantasy",
                            MovieName = "The Lord of The Ring",
                            Price = 1200.777m
                        },
                        new
                        {
                            MovieId = 2L,
                            ActionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTaken = 0,
                            Genre = "Adventure, Action, Fantasy",
                            MovieName = "Bahubali The Conclusion",
                            Price = 800.99m
                        },
                        new
                        {
                            MovieId = 3L,
                            ActionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTaken = 0,
                            Genre = "Comedy, Drama",
                            MovieName = "3 Idiots",
                            Price = 3899.777m
                        },
                        new
                        {
                            MovieId = 5L,
                            ActionDate = new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3585),
                            ActionTaken = 2,
                            ActionType = "Create",
                            Genre = "Comedy, Action",
                            MovieName = "Dhammal",
                            Price = 1145.996m
                        },
                        new
                        {
                            MovieId = 4L,
                            ActionDate = new DateTime(2025, 1, 1, 19, 35, 19, 700, DateTimeKind.Local).AddTicks(3587),
                            ActionTaken = 2,
                            ActionType = "Create",
                            Genre = "Comedy, Action",
                            MovieName = "Kamal",
                            Price = 1145.996m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

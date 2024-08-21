﻿// <auto-generated />
using System;
using Backend.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240820092512_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.LotrCardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Day")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsGreatHappening")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLotrOrTheHobbit")
                        .HasColumnType("bit");

                    b.Property<int?>("Month")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TimeValue")
                        .HasColumnType("decimal(18,3)");

                    b.Property<string>("Trivia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WikiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LotrCard");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 25,
                            Difficulty = 0,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 3,
                            Question = "The One Ring is destroyed in Mount Doom",
                            TimeValue = 43019.085m,
                            Year = 3019
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
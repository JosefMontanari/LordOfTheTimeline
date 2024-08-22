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
    [Migration("20240821160519_seeded more data")]
    partial class seededmoredata
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
                            Difficulty = 1,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 3,
                            Question = "The One Ring is destroyed in Mount Doom",
                            TimeValue = 43019.085m,
                            Trivia = "In a letter Tolkien wrote that Gollum tripping into the fires of Mt Doom was the result of divine intervention",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Mount_Doom",
                            Year = 3019
                        },
                        new
                        {
                            Id = 2,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 22,
                            Difficulty = 2,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 9,
                            Question = "Frodo is born",
                            TimeValue = 42968.262m,
                            Trivia = "In an early draft Frodo was actually named Bingo, and was the son of Bilbo",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins",
                            Year = 2968
                        },
                        new
                        {
                            Id = 3,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 1,
                            Difficulty = 2,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 3,
                            Question = "Aragorn is born",
                            TimeValue = 42931.061m,
                            Trivia = "Aragorns birth name was Estel",
                            WikiUrl = "https://tolkiengateway.net/wiki/Aragorn",
                            Year = 2931
                        },
                        new
                        {
                            Id = 4,
                            Age = 30000,
                            Category = "Lord of The Rings",
                            Difficulty = 1,
                            IsLotrOrTheHobbit = false,
                            Question = "The One Ring is made",
                            TimeValue = 31600m,
                            Trivia = "The One Ring was the only one of the primary rings that didn't hold a gem stone",
                            WikiUrl = "https://tolkiengateway.net/wiki/The_One_Ring",
                            Year = 1600
                        },
                        new
                        {
                            Id = 5,
                            Age = 30000,
                            Category = "Lord of The Rings",
                            Difficulty = 3,
                            IsLotrOrTheHobbit = false,
                            Question = "Death of Celebrimbor",
                            TimeValue = 31697m,
                            Trivia = "Celebrimbor is the grandson of Fëanor",
                            WikiUrl = "https://tolkiengateway.net/wiki/Celebrimbor",
                            Year = 1697
                        },
                        new
                        {
                            Id = 6,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 3,
                            Difficulty = 1,
                            IsGreatHappening = false,
                            IsLotrOrTheHobbit = true,
                            Month = 3,
                            Question = "The siege of Helms deep",
                            TimeValue = 43019.063m,
                            Trivia = "In the movies, Peter Jackson first wanted Arwen to fight alongside the three hunters but later cut her out of the scenes",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Helm%27s_Deep#History",
                            Year = 3019
                        },
                        new
                        {
                            Id = 7,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 1,
                            Difficulty = 1,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 7,
                            Question = "Bilbo finds The One Ring",
                            TimeValue = 42941.181m,
                            Trivia = "In the first edition of The Hobbit, Gollum gives The Ring willingly to Bilbo after the game of riddles",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins?so=search#Discovery_of_the_One_Ring",
                            Year = 2941
                        },
                        new
                        {
                            Id = 8,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Difficulty = 3,
                            IsLotrOrTheHobbit = false,
                            Question = "Sauron returns to Dol Goldur",
                            TimeValue = 42460m,
                            Trivia = "For a long time, many believed Dol Goldur was inhabited by a mere necromancer. Gandalf suspected it was Sauron.",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Sauron#The_Necromancer_of_Dol_Guldur",
                            Year = 2460
                        },
                        new
                        {
                            Id = 9,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 22,
                            Difficulty = 2,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 9,
                            Question = "Birth of Bilbo Baggins",
                            TimeValue = 42890.262m,
                            Trivia = "In Peter Jacksons adaptation of Lord of The Rings Bilbo was played by Ian Holm. Holm played Frodo in BBC's radio adaptation of the books",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins",
                            Year = 2890
                        },
                        new
                        {
                            Id = 10,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 25,
                            Difficulty = 1,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 12,
                            Question = "The fellowship leaves Rivendell",
                            TimeValue = 43018.355m,
                            Trivia = "The famous meme from the movies of Boromir in the council of Elrond is the result of Sean Bean reading his lines from the script during filming",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Council_of_Elrond",
                            Year = 3018
                        },
                        new
                        {
                            Id = 11,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 1,
                            Difficulty = 1,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 5,
                            Question = "Coronation of Aragorn",
                            TimeValue = 43019.121m,
                            Trivia = "Aragorns royal name is Elessar Telcontar, Telcontar is Elvish (Sindarin) for Strider",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Aragorn_II#As_King_of_Reunited_Gondor_and_Arnor",
                            Year = 3019
                        },
                        new
                        {
                            Id = 12,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 3,
                            Difficulty = 3,
                            IsGreatHappening = false,
                            IsLotrOrTheHobbit = true,
                            Month = 11,
                            Question = "Battle of Bywater",
                            TimeValue = 43019.303m,
                            Trivia = "The Battle of Bywater marks the end of the war of The Ring",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Battle_of_Bywater",
                            Year = 3019
                        },
                        new
                        {
                            Id = 13,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 1,
                            Difficulty = 2,
                            IsGreatHappening = false,
                            IsLotrOrTheHobbit = true,
                            Month = 5,
                            Question = "Marriage of Samwise Gamgee and Rose \"Rosie\" Cotton",
                            TimeValue = 43020.121m,
                            Trivia = "Sam and Rose had thirteen children, four of which were named Bilbo, Frodo, Merry and Pippin",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Samwise_Gamgee#After_the_War_of_the_Ring",
                            Year = 3020
                        },
                        new
                        {
                            Id = 14,
                            Age = 40000,
                            Category = "Lord of The Rings",
                            Day = 22,
                            Difficulty = 1,
                            IsGreatHappening = true,
                            IsLotrOrTheHobbit = true,
                            Month = 9,
                            Question = "Gandalf, Frodo and Bilbo leave Middle Earth",
                            TimeValue = 43021.262m,
                            Trivia = "Samwise later leaves Middle Earth to spend his last days with Frodo in the undying lands",
                            WikiUrl = "https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins#Close_of_the_Third_Age",
                            Year = 3021
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
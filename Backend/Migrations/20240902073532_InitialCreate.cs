using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotrCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trivia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WikiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true),
                    TimeValue = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    IsLotrOrTheHobbit = table.Column<bool>(type: "bit", nullable: false),
                    IsGreatHappening = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotrCard", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
                    { 1, 40000, "Lord of The Rings", 25, 1, true, true, 3, "The One Ring is destroyed in Mount Doom", 43019.085m, "In a letter Tolkien wrote that Gollum tripping into the fires of Mt Doom was the result of divine intervention", "https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Mount_Doom", 3019 },
                    { 2, 40000, "Lord of The Rings", 22, 2, true, true, 9, "Frodo is born", 42968.262m, "In an early draft Frodo was actually named Bingo, and was the son of Bilbo", "https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins", 2968 },
                    { 3, 40000, "Lord of The Rings", 1, 2, true, true, 3, "Aragorn is born", 42931.061m, "Aragorns birth name was Estel", "https://tolkiengateway.net/wiki/Aragorn", 2931 },
                    { 4, 30000, "Lord of The Rings", null, 1, null, false, null, "The One Ring is made", 31600m, "The One Ring was the only one of the primary rings that didn't hold a gem stone", "https://tolkiengateway.net/wiki/The_One_Ring", 1600 },
                    { 5, 30000, "Lord of The Rings", null, 3, null, false, null, "Death of Celebrimbor", 31697m, "Celebrimbor is the grandson of Fëanor", "https://tolkiengateway.net/wiki/Celebrimbor", 1697 },
                    { 6, 40000, "Lord of The Rings", 3, 1, false, true, 3, "The siege of Helms deep", 43019.063m, "In the movies, Peter Jackson first wanted Arwen to fight alongside the three hunters but later cut her out of the scenes", "https://lord-of-the-rings.fandom.com/wiki/Helm%27s_Deep#History", 3019 },
                    { 7, 40000, "Lord of The Rings", 1, 1, true, true, 7, "Bilbo finds The One Ring", 42941.181m, "In the first edition of The Hobbit, Gollum gives The Ring willingly to Bilbo after the game of riddles", "https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins?so=search#Discovery_of_the_One_Ring", 2941 },
                    { 8, 40000, "Lord of The Rings", null, 3, null, false, null, "Sauron returns to Dol Goldur", 42460m, "For a long time, many believed Dol Goldur was inhabited by a mere necromancer. Gandalf suspected it was Sauron.", "https://lord-of-the-rings.fandom.com/wiki/Sauron#The_Necromancer_of_Dol_Guldur", 2460 },
                    { 9, 40000, "Lord of The Rings", 22, 2, true, true, 9, "Birth of Bilbo Baggins", 42890.262m, "In Peter Jacksons adaptation of Lord of The Rings Bilbo was played by Ian Holm. Holm played Frodo in BBC's radio adaptation of the books", "https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins", 2890 },
                    { 10, 40000, "Lord of The Rings", 25, 1, true, true, 12, "The fellowship leaves Rivendell", 43018.355m, "The famous meme from the movies of Boromir in the council of Elrond is the result of Sean Bean reading his lines from the script during filming", "https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Council_of_Elrond", 3018 },
                    { 11, 40000, "Lord of The Rings", 1, 1, true, true, 5, "Coronation of Aragorn", 43019.121m, "Aragorns royal name is Elessar Telcontar, Telcontar is Elvish (Sindarin) for Strider", "https://lord-of-the-rings.fandom.com/wiki/Aragorn_II#As_King_of_Reunited_Gondor_and_Arnor", 3019 },
                    { 12, 40000, "Lord of The Rings", 3, 3, false, true, 11, "Battle of Bywater", 43019.303m, "The Battle of Bywater marks the end of the war of The Ring", "https://lord-of-the-rings.fandom.com/wiki/Battle_of_Bywater", 3019 },
                    { 13, 40000, "Lord of The Rings", 1, 2, false, true, 5, "Marriage of Samwise Gamgee and Rose \"Rosie\" Cotton", 43020.121m, "Sam and Rose had thirteen children, four of which were named Bilbo, Frodo, Merry and Pippin", "https://lord-of-the-rings.fandom.com/wiki/Samwise_Gamgee#After_the_War_of_the_Ring", 3020 },
                    { 14, 40000, "Lord of The Rings", 22, 1, true, true, 9, "Gandalf, Frodo and Bilbo leave Middle Earth", 43021.262m, "Samwise later leaves Middle Earth to spend his last days with Frodo in the undying lands", "https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins#Close_of_the_Third_Age", 3021 },
                    { 15, 40000, "Lord of The Rings", 23, 2, true, true, 11, "Battle of Five Armies", 42941.323m, "trivia", null, 2941 },
                    { 16, 40000, "Lord of The Rings", 1, 2, false, true, 11, "Death of Smaug", 42941.301m, "The name Smaug is related to the Swedish word \"smyga}\" which means to creep", null, 2941 },
                    { 17, 40000, "Lord of The Rings", null, 3, null, false, null, "Sauron returns to Mordor", 42942m, "Sauron left Dol Goldur only to later send his Nazgûl to re-occupy it", null, 2942 },
                    { 18, 40000, "Lord of The Rings", null, 3, null, false, null, "Birth of Theoden", 42948m, "Theoden was actually born in Gondor, not in Rohan", null, 2948 },
                    { 19, 50000, "Lord of The Rings", 1, 1, false, true, 3, "Death of Aragorn", 50120.061m, "Aragorn died at the age of 210", null, 120 },
                    { 20, 40000, "Lord of The Rings", 22, 1, false, true, 9, "Bilbos birthday party", 43001.262m, "Altough not very well emphazised, this was also Frodos 33th birthday party", null, 3001 },
                    { 21, 40000, "Lord of The Rings", 22, 1, true, true, 9, "Frodo comes in possession of The One Ring", 43001.262m, "This was the only time any one had ever willingly given up the ring so far in history", null, 3001 },
                    { 22, 40000, "Lord of The Rings", 20, 3, true, true, 6, "War of the Ring begins", 43018.17m, "The war officially began after Saurons forces took Osgiliath", null, 3018 },
                    { 23, 40000, "Lord of The Rings", 25, 2, true, true, 10, "Council of Elrond", 43018.295m, "Elrond had not sent invitations, Legolas, Gimli and Boromir just happened to be in Rivendell for different reasons", null, 3018 },
                    { 24, 40000, "Lord of The Rings", 15, 2, false, true, 1, "Gandalf falls from the bridge of Khazad-dûm", 43019.015m, "The battle between Gandalf and the Balrog persisted for ten days", null, 3019 },
                    { 25, 40000, "Lord of The Rings", 25, 2, true, true, 1, "Gandalf dies and returns as Gandalf the White", 43019.025m, "Gandalf is the second person ever to be resurected after figting a Balrog, Glorfindel was the first", null, 3019 },
                    { 26, 40000, "Lord of The Rings", 3, 2, false, true, 3, "Battle of Isengard", 43019.063m, "Isengard means \"Iron-enclosure\" in Old English", null, 3019 },
                    { 27, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of Denethor II", 43019.075m, "In The Return of the King Denethor is described as looking \"indeed much more like a great Wizard than Gandalf did\"", null, 3019 },
                    { 28, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of Theoden", 43019.075m, "In the books, Theoden never gets to say farewell to Éowyn since her secret indentity is never revealed to him", null, 3019 },
                    { 29, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of the Witch King", 43019.075m, "It is now known who the Witch King was prior to being made a ring wraith", null, 3019 },
                    { 30, 40000, "Lord of The Rings", 25, 1, false, true, 3, "Battle of the Morannon (Black Gate)", 43019.085m, "In the movie adaptation, Sauron was orignally meant to be present at the battle. This was later cut out", null, 3019 },
                    { 31, 40000, "Lord of The Rings", 5, 3, true, true, 10, "Death of Isildur", 40002.275m, "Before Númenor fell, Isildur took a seedling of the white tree Nimloth with him to Middle Earth. This became the first white tree of Gondor", null, 2 },
                    { 32, 30000, "Lord of The Rings", null, 3, null, false, null, "Death of Elendil", 33441m, "Elendil was (approximately) 2 meters and 41 centimeters tall", null, 3441 },
                    { 33, 30000, "Lord of The Rings", null, 3, null, false, null, "Downfall of Númenor", 33319m, "Inspired by Tolkiens recurring dreams of a great wave, a dream he later gave to Faramir in the books", null, 3319 },
                    { 34, 30000, "Lord of The Rings", null, 3, null, false, null, "War of the Last Alliance", 33429m, "Although called \"The last alliance of Elves and Men\" there where Dwarves there too", null, 3429 },
                    { 35, 40000, "Lord of The Rings", null, 3, null, false, null, "Isildur plants a sapling of the White Tree in Minas Anor", 40002m, "Minas Anor was later renamed Minas Tirith", null, 2 },
                    { 36, 40000, "Lord of The Rings", null, 3, null, false, null, "Birth of Arwen", 40241m, "Arwen was said to be the fairest of all living beings in the third age", null, 241 },
                    { 37, 40000, "Lord of The Rings", null, 4, null, false, null, "The Nazgûl reappear in Middle Earth", 41300m, "Out of the nine only one, Khamûl, is ever named", null, 1300 },
                    { 38, 40000, "Lord of The Rings", null, 3, null, false, null, "Creation of the Shire", 41601m, "After the War of the Ring, The shire was gifted more land from Aragorn", null, 1601 },
                    { 39, 40000, "Lord of The Rings", null, 3, null, false, null, "Destruction of Arnor", 41974m, "The kingdom af Arnor was later restored by Aragorn", null, 1974 },
                    { 40, 40000, "Lord of The Rings", 14, 2, false, true, 3, "Minas Tirith is besieged", 43019.074m, "", null, 3019 },
                    { 41, 40000, "Lord of The Rings", 29, 2, false, true, 9, "The hobbits reach Bree", 43018.269m, "", null, 3018 },
                    { 42, 40000, "Lord of The Rings", 13, 2, false, true, 1, "The fellowship reaches the gate of Moria", 43019.013m, "", null, 3019 },
                    { 43, 40000, "Lord of The Rings", 15, 2, false, true, 2, "The fellowship reaches Lothlórien", 43019.045m, "", null, 3019 },
                    { 44, 40000, "Lord of The Rings", 25, 2, false, true, 2, "The fellowship passes the Argonath", 43019.055m, "", null, 3019 },
                    { 45, 40000, "Lord of The Rings", 26, 2, false, true, 2, "Boromir is slain", 43019.056m, "", null, 3019 },
                    { 46, 40000, "Lord of The Rings", 5, 3, false, true, 3, "Pippin looks into the Orthanc-stone", 43019.065m, "", null, 3019 },
                    { 47, 40000, "Lord of The Rings", 7, 3, false, true, 3, "Frodo and Sam reach Henneth Annûn", 43019.067m, "", null, 3019 },
                    { 48, 40000, "Lord of The Rings", 10, 3, true, true, 3, "The Dawnless Day", 43019.07m, "", null, 3019 },
                    { 49, 40000, "Lord of The Rings", 15, 4, false, true, 3, "Second assault on Lothlórien", 43019.075m, "", null, 3019 },
                    { 50, 40000, "Lord of The Rings", 24, 2, false, true, 10, "Frodo wakes up in Rivendell after recovering from his wound", 43018.294m, "", null, 3018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotrCard");
        }
    }
}

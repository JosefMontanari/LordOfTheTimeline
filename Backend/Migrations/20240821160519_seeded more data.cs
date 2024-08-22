using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class seededmoredata : Migration
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
                    { 14, 40000, "Lord of The Rings", 22, 1, true, true, 9, "Gandalf, Frodo and Bilbo leave Middle Earth", 43021.262m, "Samwise later leaves Middle Earth to spend his last days with Frodo in the undying lands", "https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins#Close_of_the_Third_Age", 3021 }
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

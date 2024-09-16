using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class seed10morecards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
                    { 51, 50000, "Lord of The Rings", null, 3, null, false, null, "Arwen dies in Lothlórien", 50121m, "", null, 121 },
                    { 52, 50000, "Lord of The Rings", 22, 2, false, true, 9, "Samwise Gamgee leaves Middle-earth", 50061.262m, "As a ringbearer, Sam was also eligible to leave for the undying lands", null, 61 },
                    { 53, 40000, "Lord of The Rings", 22, 2, false, true, 9, "Bilbo turns 131 years old", 43021.262m, "At 131 years old, Bilbo becomes the longest living hobbit in history", null, 3021 },
                    { 54, 40000, "Lord of The Rings", 25, 3, false, true, 3, "Elanor, daughter of Samwise is born", 43021.085m, "The name Elanor comes from a flower in Lothlórien", null, 3021 },
                    { 55, 40000, "Lord of The Rings", 3, 3, true, true, 11, "Death of Saruman", 43019.303m, "In the books, Saruman dies in The Shire after the battle of Bywater", null, 3019 },
                    { 56, 40000, "Lord of The Rings", 25, 3, true, true, 6, "Aragorn finds a sapling of the White Tree", 43019.175m, "Tis tree is the seventh decendant in line from the Great Tree Telperion", null, 3019 },
                    { 57, 40000, "Lord of The Rings", 28, 3, false, true, 3, "The sacking of Dol Goldur", 43019.088m, "Galadriel throws down the walls of Dol Goldur at the end of the siege", null, 3019 },
                    { 58, 40000, "Lord of The Rings", 13, 2, true, true, 6, "Sam defeats Shelob", 43019.163m, "Shelob is the last descendant of Ungoliant, the spider who destroyed the Two Trees of Valinor", null, 3019 },
                    { 59, 10000, "Lord of The Rings", null, 3, null, false, null, "Awakening of the Elves", 11050m, "The Elves awake at Cuiviénen under a starlit sky as the sun and the moon aren't created yet", null, 1050 },
                    { 60, 20000, "Lord of The Rings", null, 3, null, false, null, "Fingolfin challenges Morgoth", 20456m, "Fingolfin strikes Morgoth seven times. Morgoth walked with a limp after the duel, and the wounds he received pained him forever", null, 456 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}

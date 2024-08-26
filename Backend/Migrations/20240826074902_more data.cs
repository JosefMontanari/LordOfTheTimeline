using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class moredata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 17,
                column: "Trivia",
                value: "Sauron left Dol Goldur only to later send his Nazgûl to re-occupy it");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 22,
                column: "Trivia",
                value: "The war officially began after Saurons forces took Osgiliath");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 26,
                column: "Trivia",
                value: "Isengard means \"Iron-enclosure\" in Old English");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 28,
                column: "Trivia",
                value: "In the books, Theoden never gets to say farewell to Éowyn since her secret indentity is never revealed to him");

            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
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
            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 17,
                column: "Trivia",
                value: "trivia");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 22,
                column: "Trivia",
                value: "trivia");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 26,
                column: "Trivia",
                value: "trivia");

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 28,
                column: "Trivia",
                value: "trivia");
        }
    }
}

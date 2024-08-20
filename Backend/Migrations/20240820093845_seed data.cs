using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 1,
                column: "Trivia",
                value: "Trivia about The Ring");

            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "ImageUrl", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
                    { 2, 40000, "Lord of The Rings", 22, 0, null, true, true, 9, "Frodo is born", 42968.262m, "Trivia about Frodo", null, 2968 },
                    { 3, 40000, "Lord of The Rings", 1, 0, null, true, true, 3, "Aragorn is born", 42931.061m, "Aragorns birth name was Estel", null, 2931 },
                    { 4, 30000, "Lord of The Rings", null, 0, null, null, false, null, "The One Ring is made", 31600m, "Trivia about The One Ring", null, 1600 },
                    { 5, 30000, "Lord of The Rings", null, 0, null, null, true, null, "Death of Celebrimbor", 31697m, "Celebrimbor is the grandson of Fëanor", null, 1697 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 1,
                column: "Trivia",
                value: null);
        }
    }
}

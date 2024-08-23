using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class morecards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
                    { 15, 40000, "Lord of The Rings", 23, 2, true, true, 11, "Battle of Five Armies", 42941.323m, "trivia", null, 2941 },
                    { 16, 40000, "Lord of The Rings", 1, 2, false, true, 11, "Death of Smaug", 42941.301m, "The name Smaug is related to the Swedish word \"smyga}\" which means to creep", null, 2941 },
                    { 17, 40000, "Lord of The Rings", null, 3, null, false, null, "Sauron returns to Mordor", 42942m, "trivia", null, 2942 },
                    { 18, 40000, "Lord of The Rings", null, 3, null, false, null, "Birth of Theoden", 42948m, "Theoden was actually born in Gondor, not in Rohan", null, 2948 },
                    { 19, 50000, "Lord of The Rings", 1, 1, false, true, 3, "Death of Aragorn", 50120.061m, "Aragorn died at the age of 210", null, 120 },
                    { 20, 40000, "Lord of The Rings", 22, 1, false, true, 9, "Bilbos birthday party", 43001.262m, "Altough not very well emphazised, this was also Frodos 33th birthday party", null, 3001 },
                    { 21, 40000, "Lord of The Rings", 22, 1, true, true, 9, "Frodo comes in possession of The One Ring", 43001.262m, "This was the only time any one had ever willingly given up the ring so far in history", null, 3001 },
                    { 22, 40000, "Lord of The Rings", 20, 3, true, true, 6, "War of the Ring begins", 43019.17m, "trivia", null, 3019 },
                    { 23, 40000, "Lord of The Rings", 25, 2, true, true, 10, "Council of Elrond", 43018.295m, "Elrond had not sent invitations, Legolas, Gimli and Boromir just happened to be in Rivendell for different reasons", null, 3018 },
                    { 24, 40000, "Lord of The Rings", 15, 2, false, true, 1, "Gandalf falls from the bridge of Khazad-dûm", 43019.015m, "The battle between Gandalf and the Balrog persisted for ten days", null, 3019 },
                    { 25, 40000, "Lord of The Rings", 25, 2, true, true, 1, "Gandalf dies and returns as Gandalf the White", 43019.025m, "Gandalf is the second person ever to be resurected after figting a Balrog, Glorfindel was the first", null, 3019 },
                    { 26, 40000, "Lord of The Rings", 3, 2, false, true, 3, "Battle of Isengard", 43019.063m, "trivia", null, 3019 },
                    { 27, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of Denethor II", 43019.075m, "In The Return of the King Denethor is described as looking \"indeed much more like a great Wizard than Gandalf did\"", null, 3019 },
                    { 28, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of Theoden", 43019.075m, "trivia", null, 3019 },
                    { 29, 40000, "Lord of The Rings", 15, 2, false, true, 3, "Death of the Witch King", 43021.075m, "It is now known who the Witch King was prior to being made a ring wraith", null, 3021 },
                    { 30, 40000, "Lord of The Rings", 25, 1, false, true, 3, "Battle of the Morannon (Black Gate)", 43019.085m, "In the movie adaptation, Sauron was orignally meant to be present at the battle. This was later cut out", null, 3019 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}

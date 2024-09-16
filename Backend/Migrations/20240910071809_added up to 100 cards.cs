using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedupto100cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Question", "Trivia" },
                values: new object[] { "Gandalf dies adter fighting the Balrog", "Gandalf is the second person ever to be resurected after fighting a Balrog, Glorfindel was the first" });

            migrationBuilder.InsertData(
                table: "LotrCard",
                columns: new[] { "Id", "Age", "Category", "Day", "Difficulty", "IsGreatHappening", "IsLotrOrTheHobbit", "Month", "Question", "TimeValue", "Trivia", "WikiUrl", "Year" },
                values: new object[,]
                {
                    { 61, 40000, "Lord of The Rings", 16, 3, false, true, 3, "The last debate", 43019.076m, "", null, 3019 },
                    { 62, 40000, "Lord of The Rings", 4, 2, false, true, 3, "Gandalf arrives at Helm's Deep", 43019.064m, "", null, 3019 },
                    { 63, 40000, "Lord of The Rings", 2, 2, false, true, 3, "Gandalf heals Theoden", 43019.062m, "", null, 3019 },
                    { 64, 40000, "Lord of The Rings", 26, 2, false, true, 2, "The breaking of the Fellowship of The Ring", 43019.056m, "", null, 3019 },
                    { 65, 40000, "Lord of The Rings", 15, 3, false, true, 2, "Gandalf returns to life", 43019.045m, "", null, 3019 },
                    { 66, 40000, "Lord of The Rings", 6, 3, false, true, 4, "Samwise Gamgee is born", 42980.096m, "J.R.R. Tolkien took the name from Gamgee Tissue,invented by a Birmingham surgeon", null, 2980 },
                    { 67, 40000, "Lord of The Rings", 22, 3, false, true, 6, "Bildo returns to Bag End and learns he's been pronounced dead", 42942.172m, "", null, 2942 },
                    { 68, 40000, "Lord of The Rings", 1, 2, false, true, 10, "Smaug is killed", 42941.271m, "", null, 2941 },
                    { 69, 40000, "Lord of The Rings", 27, 3, false, true, 4, "Bilbo leaves Bag End with Gandalf and the thirteen dwarves", 42941.117m, "", null, 2941 },
                    { 70, 40000, "Lord of The Rings", null, 3, null, false, null, "The Witch King invades Arnor", 41409m, "", null, 1409 },
                    { 71, 30000, "Lord of The Rings", null, 3, null, false, null, "Defeat of Sauron and death of Gil-galad and Elendil", 33441m, "", null, 3441 },
                    { 72, 30000, "Lord of The Rings", null, 3, null, false, null, "Battle of Dagorlad and siege of Barad-dûr", 33434m, "", null, 3434 },
                    { 73, 30000, "Lord of The Rings", null, 3, null, false, null, "The Three Rings are hidden and the War of the Elves and Sauron begins", 31693m, "", null, 1693 },
                    { 74, 30000, "Lord of The Rings", null, 3, null, false, null, "Elrond founds Rivendell", 31697m, "", null, 1697 },
                    { 75, 20000, "Lord of The Rings", null, 3, null, false, null, "The war of Wrath", 20545m, "", null, 545 },
                    { 76, 20000, "Lord of The Rings", null, 3, null, false, null, "Eärendil arrives in Valinor and asks the Valar to aid in the fight again Morgoth", 20542m, "", null, 542 },
                    { 77, 20000, "Lord of The Rings", null, 3, null, false, null, "Túrin slays Glaurung", 20499m, "", null, 499 },
                    { 78, 20000, "Lord of The Rings", null, 3, null, false, null, "Nírnaeth Arnoediad, The Battle of Unnumbered Tears, is fought.", 20472m, "", null, 472 },
                    { 79, 20000, "Lord of The Rings", null, 3, null, false, null, "Fall of Gondolin", 20510m, "", null, 510 },
                    { 80, 20000, "Lord of The Rings", null, 3, null, false, null, "Awakening of Men", 20001m, "Men awake as the sun rises for the first time", null, 1 },
                    { 81, 20000, "Lord of The Rings", null, 3, null, false, null, "Beren and Lúthien retrieve a Silmaril from Morgoths crown", 20466m, "Beren tries to take more than one Silmaril but is  in the attempt", null, 466 },
                    { 82, 20000, "Lord of The Rings", null, 3, null, false, null, "Dagor Bragollach, Battle of the Sudden Flame", 20455m, "This is the first battle were dragons were used", null, 455 },
                    { 83, 20000, "Lord of The Rings", null, 3, null, false, null, "Fingon rescues Maedhros from Thangorodrim", 20005m, "Meadhros was the oldest of Fëanors seven sons", null, 5 },
                    { 84, 30000, "Lord of The Rings", null, 3, null, false, null, "Elros is crowned the first king of Númenor", 30032m, "", null, 32 },
                    { 85, 20000, "Lord of The Rings", null, 3, null, false, null, "Lúthien dies", 20467m, "Beren and Lúthien were both revived and given mortal life, their ultimate deaths are not recorded", null, 467 },
                    { 86, 20000, "Lord of The Rings", null, 3, null, false, null, "Elrond and Elros are born", 20532m, "Elrond chooses and elven life and Elros the life of a man", null, 532 },
                    { 87, 10000, "Lord of The Rings", null, 3, null, false, null, "Creation of the Moon and the Sun", 11500m, "The Sun and Moon are created from the last fruit and flower of the Two Trees respectively", null, 1500 },
                    { 88, 10000, "Lord of The Rings", null, 3, null, false, null, "Fëanor is slain", 11497m, "Fëanor dies fighting a host of Balrogs", null, 1497 },
                    { 89, 10000, "Lord of The Rings", null, 3, null, false, null, "The Noldor are banished from Valinor", 11496m, "Most of the Noldor are subsequently given the chance to repent, except for Fëanor and his sons", null, 1496 },
                    { 90, 10000, "Lord of The Rings", null, 3, null, false, null, "Destruction of the Two Trees", 11495m, "Ungoliant sucks the light out fo the Trees and poisons them in the process", null, 1495 },
                    { 91, 10000, "Lord of The Rings", null, 3, null, false, null, "Morgoth steals the three Silmarils", 11495m, "", null, 1495 },
                    { 92, 10000, "Lord of The Rings", null, 3, null, false, null, "The first kinslaying", 11495m, "There were a total of three kinslaying among elves during the first age", null, 1495 },
                    { 93, 10000, "Lord of The Rings", null, 3, null, false, null, "Fëanor makes the Silmarils", 11450m, "The Silmarils are imbued with the light of the Two Trees and are said to be the greatest creations by any living", null, 1450 },
                    { 94, 10000, "Lord of The Rings", null, 3, null, false, null, "Morgoth is released from the halls of Mandos", 11400m, "Morgoth promises to play nice (spoiler alert: He doesn't)", null, 1400 },
                    { 95, 10000, "Lord of The Rings", null, 3, null, false, null, "Galadriel is born", 11362m, "The name Galadriel literally means \"maiden crowned with a garland of bright radiance\" as a reference to her golden hair", null, 1362 },
                    { 96, 10000, "Lord of The Rings", null, 4, null, false, null, "Birth of Fëanor", 11169m, "Fëanor is cited as the greatest craftsman and most gifted of all who have ever lived", null, 1169 },
                    { 97, 10000, "Lord of The Rings", null, 3, null, false, null, "Morgoth is brought back to Valinor in chains and imprisoned in the Halls of Mandos.", 11100m, "Morgoths original name was Melkor, the name Morgoth (Black Foe of the World) was given to him by Fëanor", null, 1100 },
                    { 98, 10000, "Lord of The Rings", null, 3, null, false, null, "Yavanna creates the Two Trees", 10001m, "Before the Sun and the Moon these two trees shone of silver and gold", null, 1 },
                    { 99, 10000, "Lord of The Rings", null, 3, null, false, null, "Varda creates the first stars", 11000m, "Varda is most beloved out of all the Valar by the Elves. Many might know her by the name \"Elbereth, Queen of the Stars\"", null, 1000 },
                    { 100, 0, "Lord of The Rings", null, 3, null, false, null, "Music of the Ainur, creation of the material universe", 0m, "The universe was sung in to existence by all the Valar. During the music Morgoth rebelled and tried to make his own music", null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Question", "Trivia" },
                values: new object[] { "Gandalf dies and returns as Gandalf the White", "Gandalf is the second person ever to be resurected after figting a Balrog, Glorfindel was the first" });
        }
    }
}

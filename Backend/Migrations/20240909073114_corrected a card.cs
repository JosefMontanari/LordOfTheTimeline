using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class correctedacard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Month", "TimeValue" },
                values: new object[] { 3, 43019.073m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LotrCard",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Month", "TimeValue" },
                values: new object[] { 6, 43019.163m });
        }
    }
}

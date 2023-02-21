using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class changingIndividualSeedValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.InsertData(
                table: "Individuals",
                columns: new[] { "Id", "AccessLevelId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 217030203, 2, "Aron", "Indongo" },
                    { 220130051, 6, "Takudzwa", "Kucherera" },
                    { 221028080, 1, "King", "Hiholike" },
                    { 221128220, 6, "Max", "Haikali" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 217030203);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221028080);

            migrationBuilder.DeleteData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221128220);

            migrationBuilder.InsertData(
                table: "Individuals",
                columns: new[] { "Id", "AccessLevelId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 101, 1, "Steven", "Balmer" },
                    { 102, 2, "Jason", "Miller" },
                    { 103, 6, "Mary", "Stevens" }
                });
        }
    }
}

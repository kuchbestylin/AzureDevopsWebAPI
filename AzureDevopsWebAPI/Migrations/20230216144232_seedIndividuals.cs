using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedIndividuals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingPasswordAndRemovingNamesToIndividual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Individuals");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Individuals",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 217030203,
                column: "Password",
                value: "0000");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051,
                column: "Password",
                value: "0000");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221028080,
                column: "Password",
                value: "0000");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221128220,
                column: "Password",
                value: "0000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Individuals",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Individuals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 217030203,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Aron", "Indongo" });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Takudzwa", "Kucherera" });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221028080,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "King", "Hiholike" });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221128220,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Max", "Haikali" });
        }
    }
}

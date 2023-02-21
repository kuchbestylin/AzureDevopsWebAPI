using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class movingFromIdToEmailAsChangelogsIndexer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndividualId",
                table: "ChangeLogs");

            migrationBuilder.AddColumn<string>(
                name: "IndividualEmail",
                table: "ChangeLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChangeLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "IndividualEmail",
                value: "220130051@students.nust.na");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndividualEmail",
                table: "ChangeLogs");

            migrationBuilder.AddColumn<int>(
                name: "IndividualId",
                table: "ChangeLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ChangeLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "IndividualId",
                value: 220130051);
        }
    }
}

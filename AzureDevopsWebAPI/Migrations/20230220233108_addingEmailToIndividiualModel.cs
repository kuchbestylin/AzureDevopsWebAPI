using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingEmailToIndividiualModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals");

            migrationBuilder.AlterColumn<int>(
                name: "AccessLevelId",
                table: "Individuals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Individuals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 217030203,
                column: "Email",
                value: "217030203@students.nust.na");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051,
                column: "Email",
                value: "220130051@students.nust.na");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221028080,
                column: "Email",
                value: "221028080@students.nust.na");

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 221128220,
                column: "Email",
                value: "221128220@students.nust.na");

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals",
                column: "AccessLevelId",
                principalTable: "AccessLevels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Individuals");

            migrationBuilder.AlterColumn<int>(
                name: "AccessLevelId",
                table: "Individuals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals",
                column: "AccessLevelId",
                principalTable: "AccessLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

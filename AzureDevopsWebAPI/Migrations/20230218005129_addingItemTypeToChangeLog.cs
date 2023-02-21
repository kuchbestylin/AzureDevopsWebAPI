using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingItemTypeToChangeLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "ChangeLogs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ChangeLogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ItemTypeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ChangeLogs_ItemTypeId",
                table: "ChangeLogs",
                column: "ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChangeLogs_ItemTypes_ItemTypeId",
                table: "ChangeLogs",
                column: "ItemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChangeLogs_ItemTypes_ItemTypeId",
                table: "ChangeLogs");

            migrationBuilder.DropIndex(
                name: "IX_ChangeLogs_ItemTypeId",
                table: "ChangeLogs");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "ChangeLogs");
        }
    }
}

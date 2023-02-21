using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingAccessLevelForeignKeyToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessLevelId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccessLevelId",
                table: "Individuals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "ChangeLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AccessLevelId",
                table: "Projects",
                column: "AccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_AccessLevelId",
                table: "Individuals",
                column: "AccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeLogs_projectId",
                table: "ChangeLogs",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChangeLogs_Projects_projectId",
                table: "ChangeLogs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals",
                column: "AccessLevelId",
                principalTable: "AccessLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AccessLevels_AccessLevelId",
                table: "Projects",
                column: "AccessLevelId",
                principalTable: "AccessLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChangeLogs_Projects_projectId",
                table: "ChangeLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_AccessLevels_AccessLevelId",
                table: "Individuals");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AccessLevels_AccessLevelId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AccessLevelId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_AccessLevelId",
                table: "Individuals");

            migrationBuilder.DropIndex(
                name: "IX_ChangeLogs_projectId",
                table: "ChangeLogs");

            migrationBuilder.DropColumn(
                name: "AccessLevelId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AccessLevelId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "ChangeLogs");
        }
    }
}

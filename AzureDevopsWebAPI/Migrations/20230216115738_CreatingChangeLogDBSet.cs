using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatingChangeLogDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "StartDateTime",
                table: "Individuals");

            migrationBuilder.AddColumn<int>(
                name: "ChangeLogId",
                table: "Individuals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    IndividualId = table.Column<int>(type: "int", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_ChangeLogId",
                table: "Individuals",
                column: "ChangeLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_ChangeLogs_ChangeLogId",
                table: "Individuals",
                column: "ChangeLogId",
                principalTable: "ChangeLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_ChangeLogs_ChangeLogId",
                table: "Individuals");

            migrationBuilder.DropTable(
                name: "ChangeLogs");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_ChangeLogId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "ChangeLogId",
                table: "Individuals");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "Individuals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Individuals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateTime",
                table: "Individuals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveChangeLogFKFromIndividualModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_ChangeLogs_ChangeLogId",
                table: "Individuals");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_ChangeLogId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "ProjectDescription",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ChangeLogId",
                table: "Individuals");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Projects",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ChangeLogs",
                newName: "ProjectId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "ChangeLogs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChangeLogs_Projects_projectId",
                table: "ChangeLogs");

            migrationBuilder.DropIndex(
                name: "IX_ChangeLogs_projectId",
                table: "ChangeLogs");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Projects",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ChangeLogs",
                newName: "ProjectId");

            migrationBuilder.AddColumn<string>(
                name: "ProjectDescription",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ChangeLogId",
                table: "Individuals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "ChangeLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}

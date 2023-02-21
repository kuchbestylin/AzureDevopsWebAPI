﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangingProjectAttributeFromValueToName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Projects",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Projects",
                newName: "Value");
        }
    }
}

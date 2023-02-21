using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AzureDevopsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedingChangelogWithRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChangeLogs",
                columns: new[] { "Id", "EndDateTime", "IndividualId", "ProjectId", "StartDateTime", "Summary" },
                values: new object[] { 3, new DateTime(2023, 2, 18, 2, 40, 0, 0, DateTimeKind.Unspecified), 220130051, 3, new DateTime(2023, 2, 17, 13, 47, 40, 0, DateTimeKind.Unspecified), "Auditing Financial Statements" });

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051,
                column: "AccessLevelId",
                value: 3);

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Planning & Analysis" },
                    { 2, "System Design" },
                    { 3, "Development" },
                    { 4, "Verification & Testing" },
                    { 5, "Documentation" },
                    { 6, "System Audit" }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fin-Statements Software Review");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Financials Database Design");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Asset-Management System Audit");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Payroll Software UI Developmet");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AccessLevelId", "Name" },
                values: new object[] { 5, 5, "Customer Balance API Review" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChangeLogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Individuals",
                keyColumn: "Id",
                keyValue: 220130051,
                column: "AccessLevelId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Asset Management Software");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Payroll Database");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Email Streaming Platform");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Financial Statements Automation");
        }
    }
}

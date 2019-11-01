using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETZ.Migrations
{
    public partial class employeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Location", "Name", "Position_Id", "Sex" },
                values: new object[] { 1, new DateTime(1979, 11, 1, 11, 42, 27, 36, DateTimeKind.Utc).AddTicks(910), "London", "Mr Peter Smith", 1, 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Location", "Name", "Position_Id", "Sex" },
                values: new object[] { 2, new DateTime(1941, 11, 1, 11, 42, 27, 36, DateTimeKind.Utc).AddTicks(5881), "Sydney", "Mr Simon Dreyfus", 2, 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Location", "Name", "Position_Id", "Sex" },
                values: new object[] { 3, new DateTime(1939, 11, 1, 11, 42, 27, 36, DateTimeKind.Utc).AddTicks(5979), "London", "Sally Elfish", 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

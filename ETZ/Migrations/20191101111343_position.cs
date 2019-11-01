using Microsoft.EntityFrameworkCore.Migrations;

namespace ETZ.Migrations
{
    public partial class position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Account Executive");

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 2, "Business Analyst" },
                    { 3, "Risk Manager" },
                    { 4, "Business Manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Fruit pies");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableNum", "SeatCount" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 12 },
                    { 6, 12 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 6 },
                    { 12, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableNum",
                keyValue: 12);
        }
    }
}

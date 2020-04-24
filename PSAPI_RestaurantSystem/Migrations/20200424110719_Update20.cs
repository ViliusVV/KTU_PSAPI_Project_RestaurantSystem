using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Changed", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 24, 14, 7, 19, 471, DateTimeKind.Local).AddTicks(2326), "Sriubos" },
                    { 16, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3353), "Burbonas" },
                    { 15, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3350), "Sidras" },
                    { 14, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3346), "Vynas" },
                    { 13, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3342), "Brendis" },
                    { 12, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3338), "Degtinė" },
                    { 11, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3335), "Konjakas" },
                    { 10, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3331), "Šampanas" },
                    { 9, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3327), "Alus" },
                    { 8, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3323), "Gaivieji gėrimai" },
                    { 7, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3320), "Miltiniai patiekalai" },
                    { 6, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3317), "Zuvis" },
                    { 5, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3313), "Vistiena" },
                    { 4, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3310), "Kiauliena" },
                    { 3, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3304), "Salotos" },
                    { 2, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3252), "Užkandžiai" },
                    { 17, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3357), "Džinas" },
                    { 18, new DateTime(2020, 4, 24, 14, 7, 19, 474, DateTimeKind.Local).AddTicks(3360), "Viskis" }
                });

            migrationBuilder.InsertData(
                table: "MenuEntries",
                columns: new[] { "MenuEntryId", "Changed", "MenuEntryName", "MenuId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dienos sriuba", 1, 1.2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Čili", 1, 3.0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cibulynė", 1, 2.0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Šaltibarščiai", 1, 2.5 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Šviežių daržovių salotos", 3, 3.0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sveikuolių salotos ", 3, 3.5 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vištienos salotos", 3, 3.5 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graikiškos salotos ", 3, 4.5 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burokėlių salotos su fetos sūriu ", 3, 4.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3);
        }
    }
}

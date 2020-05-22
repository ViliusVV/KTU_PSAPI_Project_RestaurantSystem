using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 321, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 324, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 41,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 42,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 43,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 44,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 45,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 46,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(8434), new DateTime(2020, 5, 23, 13, 46, 11, 326, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(338), new DateTime(2020, 5, 24, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(383), new DateTime(2020, 5, 25, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(969), new DateTime(2020, 5, 25, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(986), new DateTime(2020, 5, 26, 17, 46, 11, 327, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 5, 27, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(998), new DateTime(2020, 5, 29, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1002), new DateTime(2020, 5, 30, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1010), new DateTime(2020, 5, 23, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1072), new DateTime(2020, 5, 24, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1080), new DateTime(2020, 5, 25, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1101), new DateTime(2020, 5, 25, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1109), new DateTime(2020, 5, 26, 17, 46, 11, 327, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1113), new DateTime(2020, 5, 27, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1121), new DateTime(2020, 5, 29, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1125), new DateTime(2020, 5, 30, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1133), new DateTime(2020, 5, 23, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1138), new DateTime(2020, 5, 24, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1146), new DateTime(2020, 5, 25, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1150), new DateTime(2020, 5, 25, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1158), new DateTime(2020, 5, 26, 17, 46, 11, 327, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1162), new DateTime(2020, 5, 27, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1170), new DateTime(2020, 5, 29, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1179), new DateTime(2020, 5, 30, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1183), new DateTime(2020, 5, 23, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1187), new DateTime(2020, 5, 24, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1195), new DateTime(2020, 5, 25, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1199), new DateTime(2020, 5, 25, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1207), new DateTime(2020, 5, 26, 17, 46, 11, 327, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1211), new DateTime(2020, 5, 27, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1220), new DateTime(2020, 5, 29, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1224), new DateTime(2020, 5, 30, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1232), new DateTime(2020, 5, 21, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1236), new DateTime(2020, 5, 20, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 19, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1244), new DateTime(2020, 5, 20, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 18, 9, 46, 11, 327, DateTimeKind.Local).AddTicks(1248), new DateTime(2020, 5, 19, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1252), new DateTime(2020, 5, 18, 9, 46, 11, 327, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(1261), new DateTime(2020, 5, 17, 13, 46, 11, 327, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1269), new DateTime(2020, 5, 15, 21, 46, 11, 327, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 5, 46, 11, 327, DateTimeKind.Local).AddTicks(1273), new DateTime(2020, 5, 15, 1, 46, 11, 327, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 51, 11, 328, DateTimeKind.Local).AddTicks(1226), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(56), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 2,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 50, 11, 328, DateTimeKind.Local).AddTicks(3786), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3753), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3827), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 4,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 49, 11, 328, DateTimeKind.Local).AddTicks(3839), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3831), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 36, 11, 328, DateTimeKind.Local).AddTicks(3847), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3843), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 6,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 52, 11, 328, DateTimeKind.Local).AddTicks(3855), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3851), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 53, 11, 328, DateTimeKind.Local).AddTicks(3864), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3859), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 8,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 1, 11, 328, DateTimeKind.Local).AddTicks(3876), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3868), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 9,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 59, 11, 328, DateTimeKind.Local).AddTicks(3884), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3876), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 58, 11, 328, DateTimeKind.Local).AddTicks(3892), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3888), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 11,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 56, 11, 328, DateTimeKind.Local).AddTicks(3900), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3896), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 11, 328, DateTimeKind.Local).AddTicks(3909), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3905), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3913), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 47, 11, 328, DateTimeKind.Local).AddTicks(3925), new DateTime(2020, 5, 22, 13, 46, 11, 328, DateTimeKind.Local).AddTicks(3921), new DateTime(2020, 5, 22, 15, 46, 11, 328, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(2105), new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3943), new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3976), new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3984), new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4013), new DateTime(2020, 5, 20, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4021), new DateTime(2020, 5, 19, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 5, 18, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 5, 17, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4042), new DateTime(2020, 5, 16, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4046), new DateTime(2020, 5, 21, 13, 46, 11, 325, DateTimeKind.Local).AddTicks(4046) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 995, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 997, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 41,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 42,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 43,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 44,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 45,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 46,
                column: "OrderDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(2588), new DateTime(2020, 5, 18, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(3993), new DateTime(2020, 5, 19, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 5, 20, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4380), new DateTime(2020, 5, 21, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4391), new DateTime(2020, 5, 21, 22, 2, 3, 999, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4397), new DateTime(2020, 5, 22, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4400), new DateTime(2020, 5, 24, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4405), new DateTime(2020, 5, 25, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4411), new DateTime(2020, 5, 18, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4414), new DateTime(2020, 5, 19, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4419), new DateTime(2020, 5, 20, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4433), new DateTime(2020, 5, 21, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4439), new DateTime(2020, 5, 21, 22, 2, 3, 999, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4444), new DateTime(2020, 5, 22, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4447), new DateTime(2020, 5, 24, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4452), new DateTime(2020, 5, 25, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4458), new DateTime(2020, 5, 18, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4494), new DateTime(2020, 5, 19, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 5, 20, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4502), new DateTime(2020, 5, 21, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4508), new DateTime(2020, 5, 21, 22, 2, 3, 999, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4511), new DateTime(2020, 5, 22, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4516), new DateTime(2020, 5, 24, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4522), new DateTime(2020, 5, 25, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4524), new DateTime(2020, 5, 18, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4530), new DateTime(2020, 5, 19, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4533), new DateTime(2020, 5, 20, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4538), new DateTime(2020, 5, 21, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4541), new DateTime(2020, 5, 21, 22, 2, 3, 999, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4547), new DateTime(2020, 5, 22, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4552), new DateTime(2020, 5, 24, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4555), new DateTime(2020, 5, 25, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4560), new DateTime(2020, 5, 16, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4563), new DateTime(2020, 5, 15, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4569), new DateTime(2020, 5, 15, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 13, 14, 2, 3, 999, DateTimeKind.Local).AddTicks(4574), new DateTime(2020, 5, 14, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 12, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4577), new DateTime(2020, 5, 13, 14, 2, 3, 999, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 11, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4583), new DateTime(2020, 5, 12, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4585), new DateTime(2020, 5, 11, 2, 2, 3, 999, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 9, 10, 2, 3, 999, DateTimeKind.Local).AddTicks(4591), new DateTime(2020, 5, 10, 6, 2, 3, 999, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 7, 4, 0, DateTimeKind.Local).AddTicks(451), new DateTime(2020, 5, 17, 18, 2, 3, 999, DateTimeKind.Local).AddTicks(9711), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 2,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 6, 4, 0, DateTimeKind.Local).AddTicks(2238), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2213), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2268), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 4,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 5, 4, 0, DateTimeKind.Local).AddTicks(2279), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2274), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 52, 4, 0, DateTimeKind.Local).AddTicks(2285), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2282), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 6,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 8, 4, 0, DateTimeKind.Local).AddTicks(2293), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2288), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 9, 4, 0, DateTimeKind.Local).AddTicks(2299), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2293), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 8,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 17, 4, 0, DateTimeKind.Local).AddTicks(2304), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2301), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 9,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 15, 4, 0, DateTimeKind.Local).AddTicks(2312), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2307), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 14, 4, 0, DateTimeKind.Local).AddTicks(2318), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2312), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 11,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 12, 4, 0, DateTimeKind.Local).AddTicks(2324), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2321), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 11, 4, 0, DateTimeKind.Local).AddTicks(2332), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2326), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2335), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 3, 4, 0, DateTimeKind.Local).AddTicks(2343), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2337), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(2376), new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3758), new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3783), new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3789), new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3811), new DateTime(2020, 5, 15, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3816), new DateTime(2020, 5, 14, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3822), new DateTime(2020, 5, 13, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3825), new DateTime(2020, 5, 12, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3830), new DateTime(2020, 5, 11, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3836), new DateTime(2020, 5, 16, 18, 2, 3, 998, DateTimeKind.Local).AddTicks(3833) });
        }
    }
}

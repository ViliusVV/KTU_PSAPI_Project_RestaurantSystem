using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 760, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 1, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 2, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 3, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 2, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 1, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { 3, new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                column: "OrderDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(5486), new DateTime(2020, 5, 24, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7427), new DateTime(2020, 5, 25, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7472), new DateTime(2020, 5, 26, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7956), new DateTime(2020, 5, 26, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7972), new DateTime(2020, 5, 27, 16, 42, 31, 765, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7980), new DateTime(2020, 5, 28, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7985), new DateTime(2020, 5, 30, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 5, 31, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(7997), new DateTime(2020, 5, 24, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8001), new DateTime(2020, 5, 25, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8009), new DateTime(2020, 5, 26, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8030), new DateTime(2020, 5, 26, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8034), new DateTime(2020, 5, 27, 16, 42, 31, 765, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8042), new DateTime(2020, 5, 28, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8050), new DateTime(2020, 5, 30, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8054), new DateTime(2020, 5, 31, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8058), new DateTime(2020, 5, 24, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8067), new DateTime(2020, 5, 25, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8071), new DateTime(2020, 5, 26, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8079), new DateTime(2020, 5, 26, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8083), new DateTime(2020, 5, 27, 16, 42, 31, 765, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8091), new DateTime(2020, 5, 28, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8095), new DateTime(2020, 5, 30, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8104), new DateTime(2020, 5, 31, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8108), new DateTime(2020, 5, 24, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8116), new DateTime(2020, 5, 25, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8120), new DateTime(2020, 5, 26, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8124), new DateTime(2020, 5, 26, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8132), new DateTime(2020, 5, 27, 16, 42, 31, 765, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8136), new DateTime(2020, 5, 28, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 5, 30, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 5, 31, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 21, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8157), new DateTime(2020, 5, 22, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8161), new DateTime(2020, 5, 21, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 5, 21, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 19, 8, 42, 31, 765, DateTimeKind.Local).AddTicks(8173), new DateTime(2020, 5, 20, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 18, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8182), new DateTime(2020, 5, 19, 8, 42, 31, 765, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 16, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 5, 18, 12, 42, 31, 765, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8194), new DateTime(2020, 5, 16, 20, 42, 31, 765, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 4, 42, 31, 765, DateTimeKind.Local).AddTicks(8198), new DateTime(2020, 5, 16, 0, 42, 31, 765, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 47, 31, 766, DateTimeKind.Local).AddTicks(8306), new DateTime(2020, 5, 23, 12, 42, 31, 766, DateTimeKind.Local).AddTicks(7195), new DateTime(2020, 5, 23, 14, 42, 31, 766, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(653), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(719), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 4,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(727), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 13, 32, 31, 767, DateTimeKind.Local).AddTicks(739), new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(731), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 6,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(747), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 49, 31, 767, DateTimeKind.Local).AddTicks(760), new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(756), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 8,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(764), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 9,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(772), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 54, 31, 767, DateTimeKind.Local).AddTicks(784), new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(776), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 11,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(784), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 51, 31, 767, DateTimeKind.Local).AddTicks(797), new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(792), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(801), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 43, 31, 767, DateTimeKind.Local).AddTicks(813), new DateTime(2020, 5, 23, 12, 42, 31, 767, DateTimeKind.Local).AddTicks(809), new DateTime(2020, 5, 23, 14, 42, 31, 767, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(429), new DateTime(2020, 5, 23, 12, 42, 31, 763, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2600), new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2649), new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2653), new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2702), new DateTime(2020, 5, 21, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2710), new DateTime(2020, 5, 20, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2714), new DateTime(2020, 5, 19, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2723), new DateTime(2020, 5, 18, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2731), new DateTime(2020, 5, 17, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2735), new DateTime(2020, 5, 22, 12, 42, 31, 764, DateTimeKind.Local).AddTicks(2731) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 228, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 231, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ManagedByWaiterId", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(2770), new DateTime(2020, 5, 23, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(4924), new DateTime(2020, 5, 24, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(4970), new DateTime(2020, 5, 25, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5418), new DateTime(2020, 5, 26, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5434), new DateTime(2020, 5, 26, 20, 14, 19, 234, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5441), new DateTime(2020, 5, 27, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5448), new DateTime(2020, 5, 29, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5454), new DateTime(2020, 5, 30, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5461), new DateTime(2020, 5, 23, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5467), new DateTime(2020, 5, 24, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5475), new DateTime(2020, 5, 25, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5499), new DateTime(2020, 5, 26, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5506), new DateTime(2020, 5, 26, 20, 14, 19, 234, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5512), new DateTime(2020, 5, 27, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5518), new DateTime(2020, 5, 29, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5525), new DateTime(2020, 5, 30, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5531), new DateTime(2020, 5, 23, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5538), new DateTime(2020, 5, 24, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5545), new DateTime(2020, 5, 25, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5743), new DateTime(2020, 5, 26, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5750), new DateTime(2020, 5, 26, 20, 14, 19, 234, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5756), new DateTime(2020, 5, 27, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5763), new DateTime(2020, 5, 29, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5770), new DateTime(2020, 5, 30, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5776), new DateTime(2020, 5, 23, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5783), new DateTime(2020, 5, 24, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5789), new DateTime(2020, 5, 25, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5796), new DateTime(2020, 5, 26, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5802), new DateTime(2020, 5, 26, 20, 14, 19, 234, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5809), new DateTime(2020, 5, 27, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5815), new DateTime(2020, 5, 29, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5822), new DateTime(2020, 5, 30, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5828), new DateTime(2020, 5, 21, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5835), new DateTime(2020, 5, 20, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 19, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5841), new DateTime(2020, 5, 20, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 18, 12, 14, 19, 234, DateTimeKind.Local).AddTicks(5848), new DateTime(2020, 5, 19, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5855), new DateTime(2020, 5, 18, 12, 14, 19, 234, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5861), new DateTime(2020, 5, 17, 16, 14, 19, 234, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5868), new DateTime(2020, 5, 16, 0, 14, 19, 234, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 8, 14, 19, 234, DateTimeKind.Local).AddTicks(5875), new DateTime(2020, 5, 15, 4, 14, 19, 234, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 16, 14, 19, 233, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 19, 19, 235, DateTimeKind.Local).AddTicks(7421), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(6245), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 2,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9443), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9533), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 4,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9541), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 17, 4, 19, 235, DateTimeKind.Local).AddTicks(9554), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9548), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 6,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9565), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 21, 19, 235, DateTimeKind.Local).AddTicks(9578), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9572), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 8,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9582), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 9,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9589), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 26, 19, 235, DateTimeKind.Local).AddTicks(9601), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9595), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 11,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9605), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 23, 19, 235, DateTimeKind.Local).AddTicks(9617), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9611), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9621), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderId",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 15, 19, 235, DateTimeKind.Local).AddTicks(9634), new DateTime(2020, 5, 22, 16, 14, 19, 235, DateTimeKind.Local).AddTicks(9627), new DateTime(2020, 5, 22, 18, 14, 19, 235, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(6722), new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8824), new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8861), new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8868), new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8906), new DateTime(2020, 5, 20, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8914), new DateTime(2020, 5, 19, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8921), new DateTime(2020, 5, 18, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8990), new DateTime(2020, 5, 17, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8998), new DateTime(2020, 5, 16, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(9005), new DateTime(2020, 5, 21, 16, 14, 19, 232, DateTimeKind.Local).AddTicks(9001) });
        }
    }
}

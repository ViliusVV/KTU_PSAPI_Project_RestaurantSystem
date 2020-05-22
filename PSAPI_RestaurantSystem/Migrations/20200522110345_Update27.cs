using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 403, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 403, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 403, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 403, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 398, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 401, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 41,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 42,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 43,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 44,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 45,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 46,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 404, DateTimeKind.Local).AddTicks(2268), new DateTime(2020, 5, 23, 14, 3, 44, 404, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(699), new DateTime(2020, 5, 24, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(776), new DateTime(2020, 5, 25, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1375), new DateTime(2020, 5, 25, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1392), new DateTime(2020, 5, 26, 18, 3, 44, 405, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1400), new DateTime(2020, 5, 27, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1404), new DateTime(2020, 5, 29, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1412), new DateTime(2020, 5, 30, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1416), new DateTime(2020, 5, 23, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1425), new DateTime(2020, 5, 24, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1429), new DateTime(2020, 5, 25, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1449), new DateTime(2020, 5, 25, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1458), new DateTime(2020, 5, 26, 18, 3, 44, 405, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1462), new DateTime(2020, 5, 27, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1470), new DateTime(2020, 5, 29, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1478), new DateTime(2020, 5, 30, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1486), new DateTime(2020, 5, 23, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1490), new DateTime(2020, 5, 24, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1499), new DateTime(2020, 5, 25, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1503), new DateTime(2020, 5, 25, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1507), new DateTime(2020, 5, 26, 18, 3, 44, 405, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1515), new DateTime(2020, 5, 27, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1519), new DateTime(2020, 5, 29, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1527), new DateTime(2020, 5, 30, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1531), new DateTime(2020, 5, 23, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1540), new DateTime(2020, 5, 24, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1544), new DateTime(2020, 5, 25, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1552), new DateTime(2020, 5, 25, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1556), new DateTime(2020, 5, 26, 18, 3, 44, 405, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1564), new DateTime(2020, 5, 27, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1568), new DateTime(2020, 5, 29, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1576), new DateTime(2020, 5, 30, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1581), new DateTime(2020, 5, 21, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1585), new DateTime(2020, 5, 20, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 19, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1593), new DateTime(2020, 5, 20, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 18, 10, 3, 44, 405, DateTimeKind.Local).AddTicks(1597), new DateTime(2020, 5, 19, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1605), new DateTime(2020, 5, 18, 10, 3, 44, 405, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1609), new DateTime(2020, 5, 17, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1618), new DateTime(2020, 5, 15, 22, 3, 44, 405, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 6, 3, 44, 405, DateTimeKind.Local).AddTicks(1622), new DateTime(2020, 5, 15, 2, 3, 44, 405, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 8, 44, 406, DateTimeKind.Local).AddTicks(1012), new DateTime(2020, 5, 22, 14, 3, 44, 405, DateTimeKind.Local).AddTicks(9995), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 2,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 7, 44, 406, DateTimeKind.Local).AddTicks(3543), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3498), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3584), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 4,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 6, 44, 406, DateTimeKind.Local).AddTicks(3597), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3593), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 53, 44, 406, DateTimeKind.Local).AddTicks(3605), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3601), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 6,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 9, 44, 406, DateTimeKind.Local).AddTicks(3613), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3609), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 10, 44, 406, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3617), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 8,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 18, 44, 406, DateTimeKind.Local).AddTicks(3634), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 9,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 16, 44, 406, DateTimeKind.Local).AddTicks(3642), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3638), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 15, 44, 406, DateTimeKind.Local).AddTicks(3650), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3646), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 11,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 13, 44, 406, DateTimeKind.Local).AddTicks(3658), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3654), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 12, 44, 406, DateTimeKind.Local).AddTicks(3670), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3662), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3670), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 4, 44, 406, DateTimeKind.Local).AddTicks(3683), new DateTime(2020, 5, 22, 14, 3, 44, 406, DateTimeKind.Local).AddTicks(3679), new DateTime(2020, 5, 22, 16, 3, 44, 406, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(1969), new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4385), new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4426), new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4434), new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4475), new DateTime(2020, 5, 20, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4483), new DateTime(2020, 5, 19, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4487), new DateTime(2020, 5, 18, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4496), new DateTime(2020, 5, 17, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 5, 16, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4508), new DateTime(2020, 5, 21, 14, 3, 44, 402, DateTimeKind.Local).AddTicks(4504) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 34, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 36, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 32,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 33,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 34,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 35,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 36,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 37,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 38,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 39,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 40,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 41,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 42,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 43,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 44,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 45,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 46,
                column: "OrderDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(1794), new DateTime(2020, 5, 23, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(3820), new DateTime(2020, 5, 24, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(3866), new DateTime(2020, 5, 25, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4329), new DateTime(2020, 5, 25, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4350), new DateTime(2020, 5, 26, 17, 55, 48, 39, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4354), new DateTime(2020, 5, 27, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4362), new DateTime(2020, 5, 29, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4370), new DateTime(2020, 5, 30, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4374), new DateTime(2020, 5, 23, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4378), new DateTime(2020, 5, 24, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4387), new DateTime(2020, 5, 25, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4407), new DateTime(2020, 5, 25, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4415), new DateTime(2020, 5, 26, 17, 55, 48, 39, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4419), new DateTime(2020, 5, 27, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4428), new DateTime(2020, 5, 29, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4432), new DateTime(2020, 5, 30, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4440), new DateTime(2020, 5, 23, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4444), new DateTime(2020, 5, 24, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4452), new DateTime(2020, 5, 25, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4456), new DateTime(2020, 5, 25, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4465), new DateTime(2020, 5, 26, 17, 55, 48, 39, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4469), new DateTime(2020, 5, 27, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4477), new DateTime(2020, 5, 29, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4481), new DateTime(2020, 5, 30, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4489), new DateTime(2020, 5, 23, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4497), new DateTime(2020, 5, 24, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4506), new DateTime(2020, 5, 25, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4510), new DateTime(2020, 5, 25, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4518), new DateTime(2020, 5, 26, 17, 55, 48, 39, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4526), new DateTime(2020, 5, 27, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4530), new DateTime(2020, 5, 29, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4538), new DateTime(2020, 5, 30, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4543), new DateTime(2020, 5, 21, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 20, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4551), new DateTime(2020, 5, 20, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 19, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4555), new DateTime(2020, 5, 20, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 18, 9, 55, 48, 39, DateTimeKind.Local).AddTicks(4563), new DateTime(2020, 5, 19, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4571), new DateTime(2020, 5, 18, 9, 55, 48, 39, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4575), new DateTime(2020, 5, 17, 13, 55, 48, 39, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4584), new DateTime(2020, 5, 15, 21, 55, 48, 39, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 5, 55, 48, 39, DateTimeKind.Local).AddTicks(4592), new DateTime(2020, 5, 15, 1, 55, 48, 39, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 22, 13, 55, 48, 38, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 0, 48, 40, DateTimeKind.Local).AddTicks(3055), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(2099), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 2,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 59, 48, 40, DateTimeKind.Local).AddTicks(5287), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5254), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5324), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 4,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 58, 48, 40, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5332), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 45, 48, 40, DateTimeKind.Local).AddTicks(5348), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5340), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 6,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 1, 48, 40, DateTimeKind.Local).AddTicks(5357), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5353), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 2, 48, 40, DateTimeKind.Local).AddTicks(5365), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5361), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 8,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 10, 48, 40, DateTimeKind.Local).AddTicks(5373), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5369), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 9,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 8, 48, 40, DateTimeKind.Local).AddTicks(5381), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5377), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 7, 48, 40, DateTimeKind.Local).AddTicks(5394), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5385), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 11,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 5, 48, 40, DateTimeKind.Local).AddTicks(5402), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5394), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 14, 4, 48, 40, DateTimeKind.Local).AddTicks(5410), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5406), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5414), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 56, 48, 40, DateTimeKind.Local).AddTicks(5426), new DateTime(2020, 5, 22, 13, 55, 48, 40, DateTimeKind.Local).AddTicks(5418), new DateTime(2020, 5, 22, 15, 55, 48, 40, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(7841), new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9662), new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9699), new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9707), new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9736), new DateTime(2020, 5, 20, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9744), new DateTime(2020, 5, 19, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9748), new DateTime(2020, 5, 18, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9757), new DateTime(2020, 5, 17, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9761), new DateTime(2020, 5, 16, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 22, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9769), new DateTime(2020, 5, 21, 13, 55, 48, 37, DateTimeKind.Local).AddTicks(9765) });
        }
    }
}

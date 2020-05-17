using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 161, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(362), new DateTime(2020, 5, 18, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(2535), new DateTime(2020, 5, 19, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(2598), new DateTime(2020, 5, 20, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3183), new DateTime(2020, 5, 20, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 5, 21, 19, 29, 31, 166, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3216), new DateTime(2020, 5, 22, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3227), new DateTime(2020, 5, 24, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3236), new DateTime(2020, 5, 25, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3247), new DateTime(2020, 5, 18, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3255), new DateTime(2020, 5, 19, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3266), new DateTime(2020, 5, 20, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3357), new DateTime(2020, 5, 20, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3368), new DateTime(2020, 5, 21, 19, 29, 31, 166, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3380), new DateTime(2020, 5, 22, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3391), new DateTime(2020, 5, 24, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3399), new DateTime(2020, 5, 25, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3410), new DateTime(2020, 5, 18, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3421), new DateTime(2020, 5, 19, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3432), new DateTime(2020, 5, 20, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3441), new DateTime(2020, 5, 20, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3452), new DateTime(2020, 5, 21, 19, 29, 31, 166, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3463), new DateTime(2020, 5, 22, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3474), new DateTime(2020, 5, 24, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3485), new DateTime(2020, 5, 25, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3493), new DateTime(2020, 5, 18, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3504), new DateTime(2020, 5, 19, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3513), new DateTime(2020, 5, 20, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3524), new DateTime(2020, 5, 20, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3535), new DateTime(2020, 5, 21, 19, 29, 31, 166, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3546), new DateTime(2020, 5, 22, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3554), new DateTime(2020, 5, 24, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3565), new DateTime(2020, 5, 25, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3576), new DateTime(2020, 5, 16, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3587), new DateTime(2020, 5, 15, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3596), new DateTime(2020, 5, 15, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 13, 11, 29, 31, 166, DateTimeKind.Local).AddTicks(3607), new DateTime(2020, 5, 14, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 12, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3618), new DateTime(2020, 5, 13, 11, 29, 31, 166, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3626), new DateTime(2020, 5, 12, 15, 29, 31, 166, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3637), new DateTime(2020, 5, 10, 23, 29, 31, 166, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 9, 7, 29, 31, 166, DateTimeKind.Local).AddTicks(3648), new DateTime(2020, 5, 10, 3, 29, 31, 166, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 15, 29, 31, 165, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.InsertData(
                table: "TakeoutOrders",
                columns: new[] { "TakeoutOrderNum", "ConfirmationDate", "ManagedByWaiterId", "OrderDate", "OrderedByUserId", "OrderedForDate", "Price", "State" },
                values: new object[] { 1, new DateTime(2020, 5, 17, 15, 34, 31, 167, DateTimeKind.Local).AddTicks(2919), 1, new DateTime(2020, 5, 17, 15, 29, 31, 167, DateTimeKind.Local).AddTicks(1692), 5, new DateTime(2020, 5, 17, 17, 29, 31, 167, DateTimeKind.Local).AddTicks(2276), 100.0, 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(6948), new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8308), new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8336), new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8339), new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8361), new DateTime(2020, 5, 15, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8366), new DateTime(2020, 5, 14, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8369), new DateTime(2020, 5, 13, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8375), new DateTime(2020, 5, 12, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8380), new DateTime(2020, 5, 11, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8383), new DateTime(2020, 5, 16, 15, 29, 31, 164, DateTimeKind.Local).AddTicks(8383) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 232, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 235, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(1649), new DateTime(2020, 5, 18, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3104), new DateTime(2020, 5, 19, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3140), new DateTime(2020, 5, 20, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3506), new DateTime(2020, 5, 20, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3517), new DateTime(2020, 5, 21, 18, 59, 56, 237, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3522), new DateTime(2020, 5, 22, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3528), new DateTime(2020, 5, 24, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3533), new DateTime(2020, 5, 25, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3536), new DateTime(2020, 5, 18, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3542), new DateTime(2020, 5, 19, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3547), new DateTime(2020, 5, 20, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3561), new DateTime(2020, 5, 20, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3567), new DateTime(2020, 5, 21, 18, 59, 56, 237, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3572), new DateTime(2020, 5, 22, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3578), new DateTime(2020, 5, 24, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3583), new DateTime(2020, 5, 25, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3586), new DateTime(2020, 5, 18, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3592), new DateTime(2020, 5, 19, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3597), new DateTime(2020, 5, 20, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3600), new DateTime(2020, 5, 20, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3605), new DateTime(2020, 5, 21, 18, 59, 56, 237, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3611), new DateTime(2020, 5, 22, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3614), new DateTime(2020, 5, 24, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3619), new DateTime(2020, 5, 25, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3625), new DateTime(2020, 5, 18, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3628), new DateTime(2020, 5, 19, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3633), new DateTime(2020, 5, 20, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3639), new DateTime(2020, 5, 20, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3644), new DateTime(2020, 5, 21, 18, 59, 56, 237, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3647), new DateTime(2020, 5, 22, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3653), new DateTime(2020, 5, 24, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3658), new DateTime(2020, 5, 25, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3664), new DateTime(2020, 5, 16, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3666), new DateTime(2020, 5, 15, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3672), new DateTime(2020, 5, 15, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 13, 10, 59, 56, 237, DateTimeKind.Local).AddTicks(3677), new DateTime(2020, 5, 14, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 12, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3683), new DateTime(2020, 5, 13, 10, 59, 56, 237, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3686), new DateTime(2020, 5, 12, 14, 59, 56, 237, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3691), new DateTime(2020, 5, 10, 22, 59, 56, 237, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 9, 6, 59, 56, 237, DateTimeKind.Local).AddTicks(3697), new DateTime(2020, 5, 10, 2, 59, 56, 237, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(949), new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2379), new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2410), new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2434), new DateTime(2020, 5, 15, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2440), new DateTime(2020, 5, 14, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2443), new DateTime(2020, 5, 13, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2448), new DateTime(2020, 5, 12, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2454), new DateTime(2020, 5, 11, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2459), new DateTime(2020, 5, 16, 14, 59, 56, 236, DateTimeKind.Local).AddTicks(2457) });
        }
    }
}

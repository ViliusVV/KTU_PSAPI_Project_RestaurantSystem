using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InTakeoutTakeoutOrderId",
                table: "OrderedMeals",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InOrderOrderId",
                table: "OrderedMeals",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.InsertData(
                table: "OrderedMeals",
                columns: new[] { "OrderedMealId", "Comment", "InOrderOrderId", "InOrderOrderNum", "InTakeoutTakeoutOrderId", "InTakeoutTakeoutOrderNum", "MenuEntryId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, null, 33, null, null, null, 1, 6.0, 5 },
                    { 25, null, null, null, 11, null, 5, 4.5999999999999996, 4 },
                    { 23, null, null, null, 4, null, 4, 8.5999999999999996, 2 },
                    { 24, null, null, null, 8, null, 5, 4.5999999999999996, 4 },
                    { 20, null, null, null, 12, null, 1, 19.989999999999998, 2 },
                    { 19, null, null, null, 10, null, 9, 1.6000000000000001, 1 },
                    { 18, null, null, null, 7, null, 8, 2.6000000000000001, 1 },
                    { 17, null, null, null, 5, null, 7, 9.5999999999999996, 1 },
                    { 16, null, null, null, 1, null, 6, 6.2000000000000002, 5 },
                    { 15, null, 38, null, null, null, 5, 7.5999999999999996, 4 },
                    { 22, null, null, null, 2, null, 3, 6.1900000000000004, 1 },
                    { 13, null, 33, null, null, null, 3, 6.3899999999999997, 1 },
                    { 14, null, 37, null, null, null, 4, 5.6900000000000004, 3 },
                    { 11, null, 40, null, null, null, 1, 5.5899999999999999, 1 },
                    { 10, null, 37, null, null, null, 9, 3.3300000000000001, 2 },
                    { 9, null, 35, null, null, null, 8, 12.49, 1 },
                    { 8, null, 38, null, null, null, 7, 13.0, 4 },
                    { 7, null, 35, null, null, null, 6, 16.0, 12 },
                    { 6, null, 33, null, null, null, 5, 10.0, 11 },
                    { 5, null, 40, null, null, null, 4, 1.0, 10 },
                    { 4, null, 38, null, null, null, 3, 3.0, 9 },
                    { 3, null, 37, null, null, null, 2, 4.0, 4 },
                    { 2, null, 35, null, null, null, 1, 6.5, 1 },
                    { 12, null, 40, null, null, null, 2, 6.1200000000000001, 2 },
                    { 21, null, null, null, 14, null, 2, 6.1200000000000001, 3 }
                });

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
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate", "State" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 6, 4, 0, DateTimeKind.Local).AddTicks(2238), new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2213), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2232), 2 });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate", "State" },
                values: new object[] { new DateTime(2020, 5, 17, 18, 2, 4, 0, DateTimeKind.Local).AddTicks(2268), new DateTime(2020, 5, 17, 20, 2, 4, 0, DateTimeKind.Local).AddTicks(2271), 4 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderedMeals",
                keyColumn: "OrderedMealId",
                keyValue: 25);

            migrationBuilder.AlterColumn<int>(
                name: "InTakeoutTakeoutOrderId",
                table: "OrderedMeals",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InOrderOrderId",
                table: "OrderedMeals",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 316, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 318, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(4051), new DateTime(2020, 5, 18, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5458), new DateTime(2020, 5, 19, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5494), new DateTime(2020, 5, 20, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5840), new DateTime(2020, 5, 21, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5852), new DateTime(2020, 5, 21, 20, 13, 12, 320, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5857), new DateTime(2020, 5, 22, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5863), new DateTime(2020, 5, 24, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5865), new DateTime(2020, 5, 25, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5871), new DateTime(2020, 5, 18, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5876), new DateTime(2020, 5, 19, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5879), new DateTime(2020, 5, 20, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5896), new DateTime(2020, 5, 21, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5899), new DateTime(2020, 5, 21, 20, 13, 12, 320, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5904), new DateTime(2020, 5, 22, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5910), new DateTime(2020, 5, 24, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5913), new DateTime(2020, 5, 25, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5918), new DateTime(2020, 5, 18, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5921), new DateTime(2020, 5, 19, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5926), new DateTime(2020, 5, 20, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5929), new DateTime(2020, 5, 21, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5935), new DateTime(2020, 5, 21, 20, 13, 12, 320, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5937), new DateTime(2020, 5, 22, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5943), new DateTime(2020, 5, 24, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5949), new DateTime(2020, 5, 25, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5951), new DateTime(2020, 5, 18, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5957), new DateTime(2020, 5, 19, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5960), new DateTime(2020, 5, 20, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5965), new DateTime(2020, 5, 21, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5968), new DateTime(2020, 5, 21, 20, 13, 12, 320, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5973), new DateTime(2020, 5, 22, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5979), new DateTime(2020, 5, 24, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(5982), new DateTime(2020, 5, 25, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(6026), new DateTime(2020, 5, 16, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 15, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(6032), new DateTime(2020, 5, 15, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 14, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(6034), new DateTime(2020, 5, 15, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 13, 12, 13, 12, 320, DateTimeKind.Local).AddTicks(6040), new DateTime(2020, 5, 14, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 12, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(6043), new DateTime(2020, 5, 13, 12, 13, 12, 320, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(6048), new DateTime(2020, 5, 12, 16, 13, 12, 320, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 10, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(6054), new DateTime(2020, 5, 11, 0, 13, 12, 320, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 9, 8, 13, 12, 320, DateTimeKind.Local).AddTicks(6057), new DateTime(2020, 5, 10, 4, 13, 12, 320, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 1,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 18, 12, 321, DateTimeKind.Local).AddTicks(2005), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(1256), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 2,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate", "State" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 17, 12, 321, DateTimeKind.Local).AddTicks(3692), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3670), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3683), 4 });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 3,
                columns: new[] { "OrderDate", "OrderedForDate", "State" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3720), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3722), 2 });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 4,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 16, 12, 321, DateTimeKind.Local).AddTicks(3728), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3725), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 5,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 17, 3, 12, 321, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3731), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 6,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 19, 12, 321, DateTimeKind.Local).AddTicks(3742), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3739), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 7,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 20, 12, 321, DateTimeKind.Local).AddTicks(3750), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3744), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 8,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 28, 12, 321, DateTimeKind.Local).AddTicks(3756), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3750), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 9,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 26, 12, 321, DateTimeKind.Local).AddTicks(3761), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3758), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 10,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 25, 12, 321, DateTimeKind.Local).AddTicks(3769), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3764), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 11,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 23, 12, 321, DateTimeKind.Local).AddTicks(3775), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3769), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 12,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 22, 12, 321, DateTimeKind.Local).AddTicks(3780), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3778), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 13,
                columns: new[] { "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3783), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "TakeoutOrders",
                keyColumn: "TakeoutOrderNum",
                keyValue: 14,
                columns: new[] { "ConfirmationDate", "OrderDate", "OrderedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 14, 12, 321, DateTimeKind.Local).AddTicks(3792), new DateTime(2020, 5, 17, 16, 13, 12, 321, DateTimeKind.Local).AddTicks(3789), new DateTime(2020, 5, 17, 18, 13, 12, 321, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(3946), new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5309), new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5337), new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5340), new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5362), new DateTime(2020, 5, 15, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5368), new DateTime(2020, 5, 14, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5370), new DateTime(2020, 5, 13, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5376), new DateTime(2020, 5, 12, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5381), new DateTime(2020, 5, 11, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5384), new DateTime(2020, 5, 16, 16, 13, 12, 319, DateTimeKind.Local).AddTicks(5384) });
        }
    }
}

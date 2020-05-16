using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "EmployeeId", "WorkEmail" },
                values: new object[] { 1, 1, "workmail@mymail.com" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 985, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 981, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 16, 16, 48, 29, 985, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 48, 29, 985, DateTimeKind.Local).AddTicks(193), new DateTime(2020, 5, 16, 16, 48, 29, 984, DateTimeKind.Local).AddTicks(9813) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 21, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(290), new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(9916) });
        }
    }
}

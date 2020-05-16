using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "RegisteredByAdminId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BeganWork", "EmployeeState", "EndedWork", "RegisteredByAdminId", "Salary", "UserId" },
                values: new object[] { 1, new DateTime(2020, 5, 16, 16, 39, 58, 766, DateTimeKind.Local).AddTicks(6065), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1000, 1 });

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 763, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 765, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 16, 16, 39, 58, 766, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 16, 16, 39, 58, 766, DateTimeKind.Local).AddTicks(1078), new DateTime(2020, 5, 16, 16, 39, 58, 766, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees",
                column: "RegisteredByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "RegisteredByAdminId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 442, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 444, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(5901), new DateTime(2020, 5, 16, 15, 9, 30, 445, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees",
                column: "RegisteredByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

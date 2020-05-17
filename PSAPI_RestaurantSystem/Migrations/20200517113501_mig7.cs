using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ManagedByWaiterId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 716, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 718, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderNum", "Duration", "ManagedByWaiterId", "OrderDate", "Price", "State" },
                values: new object[] { 1, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Name", "Surname" },
                values: new object[,]
                {
                    { 5, "Domas", "Domaitis" },
                    { 6, "Stasys", "Stasaitis" },
                    { 7, "Martyna", "Martynaitė" },
                    { 8, "Diana", "Jablonoskienė" },
                    { 9, "Tomas", "Petraitis" },
                    { 10, "Petras", "Stasaitis" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(5707), new DateTime(2020, 5, 18, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "Comment", "PeopleCount", "ReservedByUserId", "ReservedDate", "ReservedForDate", "State" },
                values: new object[,]
                {
                    { 6, null, 2, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7580), new DateTime(2020, 5, 22, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7583), 2 },
                    { 2, null, 1, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7162), new DateTime(2020, 5, 19, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7178), 3 },
                    { 3, "Atsivesiu suni", 3, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7198), new DateTime(2020, 5, 20, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7201), 1 },
                    { 4, null, 4, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7561), new DateTime(2020, 5, 20, 22, 35, 0, 720, DateTimeKind.Local).AddTicks(7572), 3 },
                    { 8, null, 2, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7588), new DateTime(2020, 5, 25, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7591), 1 },
                    { 7, null, 2, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7583), new DateTime(2020, 5, 24, 6, 35, 0, 720, DateTimeKind.Local).AddTicks(7586), 3 },
                    { 5, null, 2, 1, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7575), new DateTime(2020, 5, 21, 18, 35, 0, 720, DateTimeKind.Local).AddTicks(7577), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(5147), new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6565), new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6601), new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6607), new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Confirmed", "Email", "LastLoginDate", "LoyalityPoints", "Password", "PersonId", "RegistrationDate" },
                values: new object[,]
                {
                    { 5, true, "domas@email.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6629), 50, "slaptozodis", 5, new DateTime(2020, 5, 15, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6609) },
                    { 6, true, "stasys@email.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6634), 60, "slaptozodis", 6, new DateTime(2020, 5, 14, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6632) },
                    { 7, true, "martyna@email.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6679), 70, "slaptozodis", 7, new DateTime(2020, 5, 13, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6676) },
                    { 8, true, "diana@email.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6684), 80, "slaptozodis", 8, new DateTime(2020, 5, 12, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6681) },
                    { 9, true, "tomas@gmail.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6690), 3, "slaptozodis", 9, new DateTime(2020, 5, 11, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6687) },
                    { 10, true, "petras@gmail.com", new DateTime(2020, 5, 17, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6695), 4, "slaptozodis", 10, new DateTime(2020, 5, 16, 14, 35, 0, 719, DateTimeKind.Local).AddTicks(6693) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BeganWork", "EmployeeState", "EndedWork", "RegisteredByAdminId", "Salary", "UserId" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(1335), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1500, 10 },
                    { 3, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(1332), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 9 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "Comment", "PeopleCount", "ReservedByUserId", "ReservedDate", "ReservedForDate", "State" },
                values: new object[,]
                {
                    { 32, null, 2, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7716), new DateTime(2020, 5, 25, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7719), 1 },
                    { 31, null, 2, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 5, 24, 6, 35, 0, 720, DateTimeKind.Local).AddTicks(7713), 3 },
                    { 30, null, 2, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7708), new DateTime(2020, 5, 22, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7710), 2 },
                    { 29, null, 2, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7702), new DateTime(2020, 5, 21, 18, 35, 0, 720, DateTimeKind.Local).AddTicks(7705), 1 },
                    { 28, null, 4, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7696), new DateTime(2020, 5, 20, 22, 35, 0, 720, DateTimeKind.Local).AddTicks(7699), 3 },
                    { 27, "Atsinesiu vezliuka", 3, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 5, 20, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7694), 1 },
                    { 26, null, 1, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7688), new DateTime(2020, 5, 19, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7691), 3 },
                    { 25, null, 2, 7, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7683), new DateTime(2020, 5, 18, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7685), 2 },
                    { 24, null, 2, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7680), new DateTime(2020, 5, 25, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7680), 1 },
                    { 23, null, 2, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7674), new DateTime(2020, 5, 24, 6, 35, 0, 720, DateTimeKind.Local).AddTicks(7677), 3 },
                    { 22, null, 2, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7669), new DateTime(2020, 5, 22, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7672), 2 },
                    { 21, null, 2, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7663), new DateTime(2020, 5, 21, 18, 35, 0, 720, DateTimeKind.Local).AddTicks(7666), 1 },
                    { 19, "Atsivesiu suni", 3, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7655), new DateTime(2020, 5, 20, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7658), 1 },
                    { 18, null, 1, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7649), new DateTime(2020, 5, 19, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7652), 3 },
                    { 17, null, 2, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7647), new DateTime(2020, 5, 18, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7647), 2 },
                    { 16, null, 2, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7641), new DateTime(2020, 5, 25, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7644), 1 },
                    { 15, null, 2, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7636), new DateTime(2020, 5, 24, 6, 35, 0, 720, DateTimeKind.Local).AddTicks(7638), 3 },
                    { 14, null, 2, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 5, 22, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7633), 2 },
                    { 13, null, 2, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7624), new DateTime(2020, 5, 21, 18, 35, 0, 720, DateTimeKind.Local).AddTicks(7627), 1 },
                    { 12, null, 4, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7622), new DateTime(2020, 5, 20, 22, 35, 0, 720, DateTimeKind.Local).AddTicks(7622), 3 },
                    { 11, "Atsivesiu kate", 3, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7605), new DateTime(2020, 5, 20, 2, 35, 0, 720, DateTimeKind.Local).AddTicks(7605), 1 },
                    { 10, null, 1, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7599), new DateTime(2020, 5, 19, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7599), 3 },
                    { 20, null, 4, 6, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 5, 20, 22, 35, 0, 720, DateTimeKind.Local).AddTicks(7663), 3 },
                    { 9, null, 2, 5, new DateTime(2020, 5, 17, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7594), new DateTime(2020, 5, 18, 14, 35, 0, 720, DateTimeKind.Local).AddTicks(7597), 2 }
                });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "WaiterId", "EmployeeId", "Tips" },
                values: new object[] { 2, 3, 200.0 });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "WaiterId", "EmployeeId", "Tips" },
                values: new object[] { 3, 4, 250.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders",
                column: "ManagedByWaiterId",
                principalTable: "Waiters",
                principalColumn: "WaiterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderNum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Waiters",
                keyColumn: "WaiterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Waiters",
                keyColumn: "WaiterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ManagedByWaiterId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BeganWork",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "MenuEntries",
                keyColumn: "MenuEntryId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 100, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 13,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 14,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 15,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 16,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 17,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 18,
                column: "Changed",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 102, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "ReservedDate", "ReservedForDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 50, 104, DateTimeKind.Local).AddTicks(1680), new DateTime(2020, 5, 18, 14, 3, 50, 104, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(1160), new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2537), new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2562), new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "LastLoginDate", "RegistrationDate" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2568), new DateTime(2020, 5, 17, 14, 3, 50, 103, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders",
                column: "ManagedByWaiterId",
                principalTable: "Waiters",
                principalColumn: "WaiterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Changed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableNum = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeatCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableNum);
                });

            migrationBuilder.CreateTable(
                name: "MenuEntries",
                columns: table => new
                {
                    MenuEntryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MenuEntryName = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Changed = table.Column<DateTime>(nullable: false),
                    MenuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuEntries", x => x.MenuEntryId);
                    table.ForeignKey(
                        name: "FK_MenuEntries_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false),
                    LoyalityPoints = table.Column<int>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PeopleCount = table.Column<int>(nullable: false),
                    ReservedForDate = table.Column<DateTime>(nullable: false),
                    ReservedDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    ReservedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_ReservedByUserId",
                        column: x => x.ReservedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<int>(nullable: false),
                    ReviewText = table.Column<string>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BeganWork = table.Column<DateTime>(nullable: false),
                    EndedWork = table.Column<DateTime>(nullable: false),
                    EmployeeState = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RegisteredByAdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkEmail = table.Column<string>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admins_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waiters",
                columns: table => new
                {
                    WaiterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tips = table.Column<double>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiters", x => x.WaiterId);
                    table.ForeignKey(
                        name: "FK_Waiters_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderNum = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ManagedByWaiterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderNum);
                    table.ForeignKey(
                        name: "FK_Orders_Waiters_ManagedByWaiterId",
                        column: x => x.ManagedByWaiterId,
                        principalTable: "Waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakeoutOrders",
                columns: table => new
                {
                    TakeoutOrderNum = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderedForDate = table.Column<DateTime>(nullable: false),
                    ConfirmationDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ManagedByWaiterId = table.Column<int>(nullable: false),
                    OrderedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeoutOrders", x => x.TakeoutOrderNum);
                    table.ForeignKey(
                        name: "FK_TakeoutOrders_Waiters_ManagedByWaiterId",
                        column: x => x.ManagedByWaiterId,
                        principalTable: "Waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakeoutOrders_Users_OrderedByUserId",
                        column: x => x.OrderedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableOccupancies",
                columns: table => new
                {
                    TableOccupancyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ReservationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOccupancies", x => x.TableOccupancyId);
                    table.ForeignKey(
                        name: "FK_TableOccupancies_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderNum",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableOccupancies_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableOccupancies_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableNum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderedMeals",
                columns: table => new
                {
                    OrderedMealId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    InTakeoutTakeoutOrderId = table.Column<int>(nullable: false),
                    InTakeoutTakeoutOrderNum = table.Column<int>(nullable: true),
                    InOrderOrderId = table.Column<int>(nullable: false),
                    InOrderOrderNum = table.Column<int>(nullable: true),
                    MenuEntryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedMeals", x => x.OrderedMealId);
                    table.ForeignKey(
                        name: "FK_OrderedMeals_Orders_InOrderOrderNum",
                        column: x => x.InOrderOrderNum,
                        principalTable: "Orders",
                        principalColumn: "OrderNum",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderedMeals_TakeoutOrders_InTakeoutTakeoutOrderNum",
                        column: x => x.InTakeoutTakeoutOrderNum,
                        principalTable: "TakeoutOrders",
                        principalColumn: "TakeoutOrderNum",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderedMeals_MenuEntries_MenuEntryId",
                        column: x => x.MenuEntryId,
                        principalTable: "MenuEntries",
                        principalColumn: "MenuEntryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Changed", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 16, 16, 45, 9, 21, DateTimeKind.Local).AddTicks(8930), "Sriubos" },
                    { 18, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3998), "Viskis" },
                    { 17, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3995), "Džinas" },
                    { 15, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3993), "Sidras" },
                    { 14, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3990), "Vynas" },
                    { 13, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3987), "Brendis" },
                    { 12, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3984), "Degtinė" },
                    { 11, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3982), "Konjakas" },
                    { 10, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3979), "Šampanas" },
                    { 16, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3993), "Burbonas" },
                    { 8, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3976), "Gaivieji gėrimai" },
                    { 7, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3973), "Miltiniai patiekalai" },
                    { 6, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3971), "Zuvis" },
                    { 5, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3968), "Vistiena" },
                    { 4, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3965), "Kiauliena" },
                    { 3, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3962), "Salotos" },
                    { 2, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3929), "Užkandžiai" },
                    { 9, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(3979), "Alus" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Jonas", "Petraitis" },
                    { 2, "Mantas", "Jablonoskis" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableNum", "SeatCount" },
                values: new object[,]
                {
                    { 10, 2 },
                    { 9, 2 },
                    { 8, 4 },
                    { 7, 4 },
                    { 6, 12 },
                    { 1, 4 },
                    { 4, 5 },
                    { 3, 4 },
                    { 2, 2 },
                    { 11, 6 },
                    { 5, 12 },
                    { 12, 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuEntries",
                columns: new[] { "MenuEntryId", "Changed", "MenuEntryName", "MenuId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6325), "Dienos sriuba", 1, 1.2 },
                    { 2, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6752), "Čili", 1, 3.0 },
                    { 3, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6774), "Cibulynė", 1, 2.0 },
                    { 4, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6777), "Šaltibarščiai", 1, 2.5 },
                    { 5, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6780), "Šviežių daržovių salotos", 3, 3.0 },
                    { 6, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6783), "Sveikuolių salotos ", 3, 3.5 },
                    { 7, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6785), "Vištienos salotos", 3, 3.5 },
                    { 8, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6788), "Graikiškos salotos ", 3, 4.5 },
                    { 9, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(6788), "Burokėlių salotos su fetos sūriu ", 3, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Confirmed", "Email", "LastLoginDate", "LoyalityPoints", "Password", "PersonId", "RegistrationDate" },
                values: new object[] { 1, true, "jonas@emai.com", new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(290), 1, "slaptozodis", 1, new DateTime(2020, 5, 16, 16, 45, 9, 24, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BeganWork", "EmployeeState", "EndedWork", "RegisteredByAdminId", "Salary", "UserId" },
                values: new object[] { 1, new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(5274), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1000, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Rating", "ReviewDate", "ReviewText", "UserId" },
                values: new object[] { 1, 2, new DateTime(2020, 5, 16, 16, 45, 9, 25, DateTimeKind.Local).AddTicks(3124), "GTFO", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_EmployeeId",
                table: "Admins",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RegisteredByAdminId",
                table: "Employees",
                column: "RegisteredByAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuEntries_MenuId",
                table: "MenuEntries",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMeals_InOrderOrderNum",
                table: "OrderedMeals",
                column: "InOrderOrderNum");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMeals_InTakeoutTakeoutOrderNum",
                table: "OrderedMeals",
                column: "InTakeoutTakeoutOrderNum");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMeals_MenuEntryId",
                table: "OrderedMeals",
                column: "MenuEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ManagedByWaiterId",
                table: "Orders",
                column: "ManagedByWaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservedByUserId",
                table: "Reservations",
                column: "ReservedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TableOccupancies_OrderId",
                table: "TableOccupancies",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TableOccupancies_ReservationId",
                table: "TableOccupancies",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_TableOccupancies_TableId",
                table: "TableOccupancies",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoutOrders_ManagedByWaiterId",
                table: "TakeoutOrders",
                column: "ManagedByWaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_TakeoutOrders_OrderedByUserId",
                table: "TakeoutOrders",
                column: "OrderedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Waiters_EmployeeId",
                table: "Waiters",
                column: "EmployeeId",
                unique: true);

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
                name: "FK_Admins_Employees_EmployeeId",
                table: "Admins");

            migrationBuilder.DropTable(
                name: "OrderedMeals");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "TableOccupancies");

            migrationBuilder.DropTable(
                name: "TakeoutOrders");

            migrationBuilder.DropTable(
                name: "MenuEntries");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Waiters");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}

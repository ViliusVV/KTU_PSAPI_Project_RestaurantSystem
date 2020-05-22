using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class m1 : Migration
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
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    ManagedByWaiterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Waiters_ManagedByWaiterId",
                        column: x => x.ManagedByWaiterId,
                        principalTable: "Waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TakeoutOrders",
                columns: table => new
                {
                    TakeoutOrderId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_TakeoutOrders", x => x.TakeoutOrderId);
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
                        principalColumn: "OrderId",
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
                    InTakeoutTakeoutOrderId = table.Column<int>(nullable: true),
                    InOrderOrderId = table.Column<int>(nullable: true),
                    MenuEntryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedMeals", x => x.OrderedMealId);
                    table.ForeignKey(
                        name: "FK_OrderedMeals_Orders_InOrderOrderId",
                        column: x => x.InOrderOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderedMeals_TakeoutOrders_InTakeoutTakeoutOrderId",
                        column: x => x.InTakeoutTakeoutOrderId,
                        principalTable: "TakeoutOrders",
                        principalColumn: "TakeoutOrderId",
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
                    { 1, new DateTime(2020, 5, 22, 15, 10, 49, 626, DateTimeKind.Local).AddTicks(5686), "Sriubos" },
                    { 17, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9607), "Džinas" },
                    { 16, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9604), "Burbonas" },
                    { 15, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9601), "Sidras" },
                    { 14, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9599), "Vynas" },
                    { 13, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9596), "Brendis" },
                    { 12, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9593), "Degtinė" },
                    { 11, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9590), "Konjakas" },
                    { 10, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9590), "Šampanas" },
                    { 18, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9607), "Viskis" },
                    { 8, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9585), "Gaivieji gėrimai" },
                    { 7, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9582), "Miltiniai patiekalai" },
                    { 6, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9579), "Zuvis" },
                    { 5, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9579), "Vistiena" },
                    { 4, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9577), "Kiauliena" },
                    { 3, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9571), "Salotos" },
                    { 2, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9543), "Užkandžiai" },
                    { 9, new DateTime(2020, 5, 22, 15, 10, 49, 628, DateTimeKind.Local).AddTicks(9588), "Alus" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Duration", "ManagedByWaiterId", "OrderDate", "Price", "State" },
                values: new object[,]
                {
                    { 23, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9663), 0.0, 6 },
                    { 24, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9663), 0.0, 6 },
                    { 25, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9666), 0.0, 6 },
                    { 26, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9669), 0.0, 6 },
                    { 27, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9672), 0.0, 6 },
                    { 28, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9674), 0.0, 6 },
                    { 29, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9674), 0.0, 6 },
                    { 30, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9677), 0.0, 6 },
                    { 42, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(384), 0.0, 1 },
                    { 32, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9683), 0.0, 6 },
                    { 41, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(381), 0.0, 1 },
                    { 43, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(386), 0.0, 1 },
                    { 44, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(386), 0.0, 1 },
                    { 45, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(389), 0.0, 1 },
                    { 46, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(392), 0.0, 1 },
                    { 22, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9660), 0.0, 6 },
                    { 31, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9680), 0.0, 6 },
                    { 20, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9655), 0.0, 6 },
                    { 21, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9658), 0.0, 6 },
                    { 18, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9652), 0.0, 6 },
                    { 19, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9652), 0.0, 6 },
                    { 1, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(8522), 0.0, 6 },
                    { 2, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9569), 0.0, 6 },
                    { 3, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9616), 0.0, 6 },
                    { 4, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9619), 0.0, 6 },
                    { 5, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9622), 0.0, 6 },
                    { 6, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9624), 0.0, 6 },
                    { 7, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9627), 0.0, 6 },
                    { 9, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9630), 0.0, 6 },
                    { 8, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9627), 0.0, 6 },
                    { 11, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9636), 0.0, 6 },
                    { 12, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9638), 0.0, 6 },
                    { 13, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9641), 0.0, 6 },
                    { 14, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9641), 0.0, 6 },
                    { 15, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9644), 0.0, 6 },
                    { 16, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9647), 0.0, 6 },
                    { 17, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9649), 0.0, 6 },
                    { 10, 0, null, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9633), 0.0, 6 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Name", "Surname" },
                values: new object[,]
                {
                    { 7, "Martyna", "Martynaitė" },
                    { 9, "Tomas", "Petraitis" },
                    { 10, "Petras", "Stasaitis" },
                    { 8, "Diana", "Jablonoskienė" },
                    { 6, "Stasys", "Stasaitis" },
                    { 2, "Mantas", "Jablonoskis" },
                    { 4, "Petras", "Petraitis" },
                    { 3, "Tomas", "Tomaitis" },
                    { 1, "Jonas", "Petraitis" },
                    { 5, "Domas", "Domaitis" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableNum", "SeatCount" },
                values: new object[,]
                {
                    { 11, 6 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 12 },
                    { 6, 12 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 2 },
                    { 10, 2 },
                    { 12, 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuEntries",
                columns: new[] { "MenuEntryId", "Changed", "MenuEntryName", "MenuId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(1776), "Dienos sriuba", 1, 1.2 },
                    { 2, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2203), "Čili", 1, 3.0 },
                    { 3, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2222), "Cibulynė", 1, 2.0 },
                    { 4, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2225), "Šaltibarščiai", 1, 2.5 },
                    { 5, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2228), "Šviežių daržovių salotos", 3, 3.0 },
                    { 6, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2231), "Sveikuolių salotos ", 3, 3.5 },
                    { 7, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2234), "Vištienos salotos", 3, 3.5 },
                    { 8, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2236), "Graikiškos salotos ", 3, 4.5 },
                    { 9, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(2239), "Burokėlių salotos su fetos sūriu ", 3, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "TableOccupancies",
                columns: new[] { "TableOccupancyId", "OrderId", "ReservationId", "TableId" },
                values: new object[,]
                {
                    { 44, 44, null, 12 },
                    { 43, 43, null, 12 },
                    { 42, 42, null, 12 },
                    { 41, 41, null, 12 },
                    { 46, 46, null, 12 },
                    { 45, 45, null, 12 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Confirmed", "Email", "LastLoginDate", "LoyalityPoints", "Password", "PersonId", "RegistrationDate" },
                values: new object[,]
                {
                    { 6, true, "stasys@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7171), 60, "slaptozodis", 6, new DateTime(2020, 5, 19, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7168) },
                    { 7, true, "martyna@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7176), 70, "slaptozodis", 7, new DateTime(2020, 5, 18, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7173) },
                    { 8, true, "diana@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7182), 80, "slaptozodis", 8, new DateTime(2020, 5, 17, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7179) },
                    { 9, true, "tomas@gmail.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7184), 3, "slaptozodis", 9, new DateTime(2020, 5, 16, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7184) },
                    { 10, true, "petras@gmail.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7190), 4, "slaptozodis", 10, new DateTime(2020, 5, 21, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7187) },
                    { 3, true, "tomas@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7140), 20, "slaptozodis", 3, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7137) },
                    { 2, true, "mantas@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7118), 10, "slaptozodis", 2, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7093) },
                    { 1, true, "jonas@emai.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(5766), 1, "slaptozodis", 1, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(5378) },
                    { 5, true, "domas@email.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7165), 50, "slaptozodis", 5, new DateTime(2020, 5, 20, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7148) },
                    { 4, true, "petraitis@gmail.com", new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7146), 5, "slaptozodis", 4, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(7143) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BeganWork", "EmployeeState", "EndedWork", "RegisteredByAdminId", "Salary", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(844), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1000, 1 },
                    { 3, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(1576), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2000, 9 },
                    { 2, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(1554), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3000, 2 },
                    { 4, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(1579), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1500, 10 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "Comment", "PeopleCount", "ReservedByUserId", "ReservedDate", "ReservedForDate", "State" },
                values: new object[,]
                {
                    { 4, null, 4, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7394), new DateTime(2020, 5, 25, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7402), 3 },
                    { 39, null, 2, 5, new DateTime(2020, 5, 15, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7638), new DateTime(2020, 5, 15, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7641), 3 },
                    { 40, null, 2, 5, new DateTime(2020, 5, 14, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7643), new DateTime(2020, 5, 15, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7643), 1 },
                    { 17, null, 2, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7541), new DateTime(2020, 5, 23, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7544), 2 },
                    { 18, null, 1, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7547), new DateTime(2020, 5, 24, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7547), 3 },
                    { 19, "Atsivesiu suni", 3, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7549), new DateTime(2020, 5, 25, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7552), 1 },
                    { 20, null, 4, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7555), new DateTime(2020, 5, 25, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7558), 3 },
                    { 21, null, 2, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7558), new DateTime(2020, 5, 26, 19, 10, 49, 630, DateTimeKind.Local).AddTicks(7560), 1 },
                    { 22, null, 2, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7563), new DateTime(2020, 5, 27, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7566), 2 },
                    { 38, null, 2, 5, new DateTime(2020, 5, 15, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7632), new DateTime(2020, 5, 17, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7635), 2 },
                    { 23, null, 2, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7569), new DateTime(2020, 5, 29, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7569), 3 },
                    { 25, null, 2, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7577), new DateTime(2020, 5, 23, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7580), 2 },
                    { 26, null, 1, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7580), new DateTime(2020, 5, 24, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7583), 3 },
                    { 27, "Atsinesiu vezliuka", 3, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7585), new DateTime(2020, 5, 25, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7588), 1 },
                    { 28, null, 4, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7588), new DateTime(2020, 5, 25, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7591), 3 },
                    { 29, null, 2, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7594), new DateTime(2020, 5, 26, 19, 10, 49, 630, DateTimeKind.Local).AddTicks(7596), 1 },
                    { 30, null, 2, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7599), new DateTime(2020, 5, 27, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7599), 2 },
                    { 31, null, 2, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7602), new DateTime(2020, 5, 29, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7605), 3 },
                    { 32, null, 2, 7, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7607), new DateTime(2020, 5, 30, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7607), 1 },
                    { 24, null, 2, 6, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7571), new DateTime(2020, 5, 30, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7574), 1 },
                    { 3, "Atsivesiu suni", 3, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7051), new DateTime(2020, 5, 25, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7053), 1 },
                    { 37, null, 2, 5, new DateTime(2020, 5, 17, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7630), new DateTime(2020, 5, 18, 11, 10, 49, 630, DateTimeKind.Local).AddTicks(7630), 1 },
                    { 1, null, 2, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(5635), new DateTime(2020, 5, 23, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(6003), 2 },
                    { 5, null, 2, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7405), new DateTime(2020, 5, 26, 19, 10, 49, 630, DateTimeKind.Local).AddTicks(7408), 1 },
                    { 6, null, 2, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7411), new DateTime(2020, 5, 27, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7414), 2 },
                    { 7, null, 2, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7416), new DateTime(2020, 5, 29, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7416), 3 },
                    { 8, null, 2, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7419), new DateTime(2020, 5, 30, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7422), 1 },
                    { 2, null, 1, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7012), new DateTime(2020, 5, 24, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7028), 3 },
                    { 36, null, 4, 5, new DateTime(2020, 5, 18, 11, 10, 49, 630, DateTimeKind.Local).AddTicks(7624), new DateTime(2020, 5, 19, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7627), 3 },
                    { 10, null, 1, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7430), new DateTime(2020, 5, 24, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7430), 3 },
                    { 9, null, 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7425), new DateTime(2020, 5, 23, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7427), 2 },
                    { 12, null, 4, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7447), new DateTime(2020, 5, 25, 23, 10, 49, 630, DateTimeKind.Local).AddTicks(7450), 3 },
                    { 13, null, 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7452), new DateTime(2020, 5, 26, 19, 10, 49, 630, DateTimeKind.Local).AddTicks(7455), 1 },
                    { 14, null, 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7458), new DateTime(2020, 5, 27, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7458), 2 },
                    { 15, null, 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7533), new DateTime(2020, 5, 29, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7535), 3 },
                    { 16, null, 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7538), new DateTime(2020, 5, 30, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7538), 1 },
                    { 33, null, 2, 5, new DateTime(2020, 5, 20, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7610), new DateTime(2020, 5, 21, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7613), 2 },
                    { 34, null, 1, 5, new DateTime(2020, 5, 20, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7616), new DateTime(2020, 5, 20, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7616), 3 },
                    { 11, "Atsivesiu kate", 3, 5, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(7433), new DateTime(2020, 5, 25, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7436), 1 },
                    { 35, "Atsivesiu suni", 3, 5, new DateTime(2020, 5, 19, 7, 10, 49, 630, DateTimeKind.Local).AddTicks(7619), new DateTime(2020, 5, 20, 3, 10, 49, 630, DateTimeKind.Local).AddTicks(7621), 1 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Rating", "ReviewDate", "ReviewText", "UserId" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(9398), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.", 3 },
                    { 2, 5, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(9379), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.", 2 },
                    { 1, 2, new DateTime(2020, 5, 22, 15, 10, 49, 629, DateTimeKind.Local).AddTicks(8664), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "EmployeeId", "WorkEmail" },
                values: new object[] { 1, 1, "workmail@mymail.com" });

            migrationBuilder.InsertData(
                table: "TableOccupancies",
                columns: new[] { "TableOccupancyId", "OrderId", "ReservationId", "TableId" },
                values: new object[,]
                {
                    { 19, 19, 19, 12 },
                    { 20, 20, 20, 12 },
                    { 21, 21, 21, 12 },
                    { 22, 22, 22, 12 },
                    { 23, 23, 23, 12 },
                    { 24, 24, 24, 12 },
                    { 18, 18, 18, 12 },
                    { 25, 25, 25, 12 },
                    { 27, 27, 27, 12 },
                    { 28, 28, 28, 12 },
                    { 29, 29, 29, 12 },
                    { 30, 30, 30, 12 },
                    { 31, 31, 31, 12 },
                    { 32, 32, 32, 12 },
                    { 26, 26, 26, 12 },
                    { 17, 17, 17, 12 },
                    { 16, 16, 16, 12 },
                    { 15, 15, 15, 12 },
                    { 1, 1, 1, 12 },
                    { 2, 2, 2, 12 },
                    { 3, 3, 3, 12 },
                    { 4, 4, 4, 12 },
                    { 5, 5, 5, 12 },
                    { 6, 6, 6, 12 },
                    { 7, 7, 7, 12 },
                    { 8, 8, 8, 12 },
                    { 9, 9, 9, 12 },
                    { 10, 10, 10, 12 },
                    { 11, 11, 11, 12 },
                    { 12, 12, 12, 12 },
                    { 13, 13, 13, 12 },
                    { 14, 14, 14, 12 }
                });

            migrationBuilder.InsertData(
                table: "Waiters",
                columns: new[] { "WaiterId", "EmployeeId", "Tips" },
                values: new object[,]
                {
                    { 1, 2, 100.0 },
                    { 2, 3, 200.0 },
                    { 3, 4, 250.0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Duration", "ManagedByWaiterId", "OrderDate", "Price", "State" },
                values: new object[,]
                {
                    { 33, 45, 1, new DateTime(2020, 5, 22, 15, 10, 49, 630, DateTimeKind.Local).AddTicks(9685), 10.0, 5 },
                    { 47, 359, 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(395), 9999.1200000000008, 5 },
                    { 39, 0, 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(375), 0.0, 4 },
                    { 36, 0, 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(370), 0.0, 4 },
                    { 40, 153, 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(378), 65.0, 5 },
                    { 35, 51, 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(350), 11.0, 5 },
                    { 37, 30, 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(372), 20.0, 5 },
                    { 38, 37, 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(372), 40.0, 5 },
                    { 34, 0, 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(339), 0.0, 4 }
                });

            migrationBuilder.InsertData(
                table: "TakeoutOrders",
                columns: new[] { "TakeoutOrderId", "ConfirmationDate", "ManagedByWaiterId", "OrderDate", "OrderedByUserId", "OrderedForDate", "Price", "State" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 5, 22, 15, 22, 49, 631, DateTimeKind.Local).AddTicks(5712), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5706), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5709), 100.0, 3 },
                    { 11, new DateTime(2020, 5, 22, 15, 20, 49, 631, DateTimeKind.Local).AddTicks(5717), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5714), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5714), 100.0, 2 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5725), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5728), 100.0, 4 },
                    { 5, new DateTime(2020, 5, 22, 16, 0, 49, 631, DateTimeKind.Local).AddTicks(5678), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5676), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5676), 13.5, 3 },
                    { 7, new DateTime(2020, 5, 22, 15, 17, 49, 631, DateTimeKind.Local).AddTicks(5692), 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5687), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5689), 100.0, 3 },
                    { 2, new DateTime(2020, 5, 22, 15, 14, 49, 631, DateTimeKind.Local).AddTicks(5631), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5609), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5623), 10.109999999999999, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5662), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5665), 100.0, 4 },
                    { 6, new DateTime(2020, 5, 22, 15, 16, 49, 631, DateTimeKind.Local).AddTicks(5687), 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5681), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5684), 100.0, 1 },
                    { 9, new DateTime(2020, 5, 22, 15, 23, 49, 631, DateTimeKind.Local).AddTicks(5706), 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5701), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5703), 100.0, 1 },
                    { 14, new DateTime(2020, 5, 22, 15, 11, 49, 631, DateTimeKind.Local).AddTicks(5734), 2, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5731), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5734), 100.0, 3 },
                    { 1, new DateTime(2020, 5, 22, 15, 15, 49, 631, DateTimeKind.Local).AddTicks(3894), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(3176), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(3539), 100.0, 3 },
                    { 4, new DateTime(2020, 5, 22, 15, 13, 49, 631, DateTimeKind.Local).AddTicks(5673), 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5667), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5670), 15.49, 2 },
                    { 8, new DateTime(2020, 5, 22, 15, 25, 49, 631, DateTimeKind.Local).AddTicks(5698), 1, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5695), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5695), 100.0, 2 },
                    { 12, new DateTime(2020, 5, 22, 15, 19, 49, 631, DateTimeKind.Local).AddTicks(5723), 3, new DateTime(2020, 5, 22, 15, 10, 49, 631, DateTimeKind.Local).AddTicks(5720), 5, new DateTime(2020, 5, 22, 17, 10, 49, 631, DateTimeKind.Local).AddTicks(5723), 100.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderedMeals",
                columns: new[] { "OrderedMealId", "Comment", "InOrderOrderId", "InTakeoutTakeoutOrderId", "MenuEntryId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, null, 33, null, 1, 6.0, 5 },
                    { 14, null, 37, null, 4, 5.6900000000000004, 3 },
                    { 5, null, 40, null, 4, 1.0, 10 },
                    { 11, null, 40, null, 1, 5.5899999999999999, 1 },
                    { 12, null, 40, null, 2, 6.1200000000000001, 2 },
                    { 21, null, null, 14, 2, 6.1200000000000001, 3 },
                    { 26, null, 47, null, 1, 100.12, 31 },
                    { 27, null, 47, null, 2, 163.21000000000001, 13 },
                    { 28, null, 47, null, 3, 240.12, 90 },
                    { 29, null, 47, null, 4, 321.66000000000003, 31 },
                    { 30, null, 47, null, 5, 45.939999999999998, 23 },
                    { 31, null, 47, null, 6, 100.61, 67 },
                    { 32, null, 47, null, 7, 544.87, 84 },
                    { 33, null, 47, null, 8, 202.22, 101 },
                    { 34, null, 47, null, 9, 156.12, 72 },
                    { 23, null, null, 4, 4, 8.5999999999999996, 2 },
                    { 18, null, null, 7, 8, 2.6000000000000001, 1 },
                    { 3, null, 37, null, 2, 4.0, 4 },
                    { 10, null, 37, null, 9, 3.3300000000000001, 2 },
                    { 16, null, null, 1, 6, 6.2000000000000002, 5 },
                    { 6, null, 33, null, 5, 10.0, 11 },
                    { 13, null, 33, null, 3, 6.3899999999999997, 1 },
                    { 4, null, 38, null, 3, 3.0, 9 },
                    { 8, null, 38, null, 7, 13.0, 4 },
                    { 15, null, 38, null, 5, 7.5999999999999996, 4 },
                    { 9, null, 35, null, 8, 12.49, 1 },
                    { 22, null, null, 2, 3, 6.1900000000000004, 1 },
                    { 20, null, null, 12, 1, 19.989999999999998, 2 },
                    { 17, null, null, 5, 7, 9.5999999999999996, 1 },
                    { 24, null, null, 8, 5, 4.5999999999999996, 4 },
                    { 19, null, null, 10, 9, 1.6000000000000001, 1 },
                    { 25, null, null, 11, 5, 4.5999999999999996, 4 },
                    { 2, null, 35, null, 1, 6.5, 1 },
                    { 7, null, 35, null, 6, 16.0, 12 }
                });

            migrationBuilder.InsertData(
                table: "TableOccupancies",
                columns: new[] { "TableOccupancyId", "OrderId", "ReservationId", "TableId" },
                values: new object[,]
                {
                    { 40, 40, 40, 5 },
                    { 38, 38, 38, 11 },
                    { 37, 37, 37, 12 },
                    { 35, 33, 33, 4 },
                    { 34, 33, 33, 10 },
                    { 33, 33, 33, 2 },
                    { 47, 47, null, 1 },
                    { 39, 40, 40, 3 },
                    { 36, 35, 35, 11 }
                });

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
                name: "IX_OrderedMeals_InOrderOrderId",
                table: "OrderedMeals",
                column: "InOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMeals_InTakeoutTakeoutOrderId",
                table: "OrderedMeals",
                column: "InTakeoutTakeoutOrderId");

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

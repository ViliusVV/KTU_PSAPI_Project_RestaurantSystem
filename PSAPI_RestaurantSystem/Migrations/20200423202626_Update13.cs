using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderedByUserId",
                table: "TakeoutOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "MenuEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TakeoutOrders_OrderedByUserId",
                table: "TakeoutOrders",
                column: "OrderedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuEntries_MenuId",
                table: "MenuEntries",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuEntries_Menus_MenuId",
                table: "MenuEntries",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoutOrders_Users_OrderedByUserId",
                table: "TakeoutOrders",
                column: "OrderedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuEntries_Menus_MenuId",
                table: "MenuEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoutOrders_Users_OrderedByUserId",
                table: "TakeoutOrders");

            migrationBuilder.DropIndex(
                name: "IX_TakeoutOrders_OrderedByUserId",
                table: "TakeoutOrders");

            migrationBuilder.DropIndex(
                name: "IX_MenuEntries_MenuId",
                table: "MenuEntries");

            migrationBuilder.DropColumn(
                name: "OrderedByUserId",
                table: "TakeoutOrders");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "MenuEntries");
        }
    }
}

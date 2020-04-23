using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InOrderOrderId",
                table: "OrderedMeals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InOrderOrderNum",
                table: "OrderedMeals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InTakeoutTakeoutOrderId",
                table: "OrderedMeals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InTakeoutTakeoutOrderNum",
                table: "OrderedMeals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuEntryId",
                table: "OrderedMeals",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedMeals_Orders_InOrderOrderNum",
                table: "OrderedMeals",
                column: "InOrderOrderNum",
                principalTable: "Orders",
                principalColumn: "OrderNum",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedMeals_TakeoutOrders_InTakeoutTakeoutOrderNum",
                table: "OrderedMeals",
                column: "InTakeoutTakeoutOrderNum",
                principalTable: "TakeoutOrders",
                principalColumn: "TakeoutOrderNum",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedMeals_MenuEntries_MenuEntryId",
                table: "OrderedMeals",
                column: "MenuEntryId",
                principalTable: "MenuEntries",
                principalColumn: "MenuEntryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedMeals_Orders_InOrderOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedMeals_TakeoutOrders_InTakeoutTakeoutOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedMeals_MenuEntries_MenuEntryId",
                table: "OrderedMeals");

            migrationBuilder.DropIndex(
                name: "IX_OrderedMeals_InOrderOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropIndex(
                name: "IX_OrderedMeals_InTakeoutTakeoutOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropIndex(
                name: "IX_OrderedMeals_MenuEntryId",
                table: "OrderedMeals");

            migrationBuilder.DropColumn(
                name: "InOrderOrderId",
                table: "OrderedMeals");

            migrationBuilder.DropColumn(
                name: "InOrderOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropColumn(
                name: "InTakeoutTakeoutOrderId",
                table: "OrderedMeals");

            migrationBuilder.DropColumn(
                name: "InTakeoutTakeoutOrderNum",
                table: "OrderedMeals");

            migrationBuilder.DropColumn(
                name: "MenuEntryId",
                table: "OrderedMeals");
        }
    }
}

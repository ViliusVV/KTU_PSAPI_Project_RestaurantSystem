using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagedByWaiterId",
                table: "TakeoutOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagedByWaiterId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TakeoutOrders_ManagedByWaiterId",
                table: "TakeoutOrders",
                column: "ManagedByWaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ManagedByWaiterId",
                table: "Orders",
                column: "ManagedByWaiterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders",
                column: "ManagedByWaiterId",
                principalTable: "Waiters",
                principalColumn: "WaiterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakeoutOrders_Waiters_ManagedByWaiterId",
                table: "TakeoutOrders",
                column: "ManagedByWaiterId",
                principalTable: "Waiters",
                principalColumn: "WaiterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Waiters_ManagedByWaiterId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_TakeoutOrders_Waiters_ManagedByWaiterId",
                table: "TakeoutOrders");

            migrationBuilder.DropIndex(
                name: "IX_TakeoutOrders_ManagedByWaiterId",
                table: "TakeoutOrders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ManagedByWaiterId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ManagedByWaiterId",
                table: "TakeoutOrders");

            migrationBuilder.DropColumn(
                name: "ManagedByWaiterId",
                table: "Orders");
        }
    }
}

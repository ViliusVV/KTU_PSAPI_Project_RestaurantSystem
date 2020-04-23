using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancy_Orders_OrderId",
                table: "TableOccupancy");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancy_Reservations_ReservationId",
                table: "TableOccupancy");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancy_Tables_TableId",
                table: "TableOccupancy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableOccupancy",
                table: "TableOccupancy");

            migrationBuilder.RenameTable(
                name: "TableOccupancy",
                newName: "TableOccupancies");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancy_TableId",
                table: "TableOccupancies",
                newName: "IX_TableOccupancies_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancy_ReservationId",
                table: "TableOccupancies",
                newName: "IX_TableOccupancies_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancy_OrderId",
                table: "TableOccupancies",
                newName: "IX_TableOccupancies_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableOccupancies",
                table: "TableOccupancies",
                column: "TableOccupancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancies_Orders_OrderId",
                table: "TableOccupancies",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancies_Tables_TableId",
                table: "TableOccupancies",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableNum",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancies_Orders_OrderId",
                table: "TableOccupancies");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies");

            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancies_Tables_TableId",
                table: "TableOccupancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableOccupancies",
                table: "TableOccupancies");

            migrationBuilder.RenameTable(
                name: "TableOccupancies",
                newName: "TableOccupancy");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancies_TableId",
                table: "TableOccupancy",
                newName: "IX_TableOccupancy_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancies_ReservationId",
                table: "TableOccupancy",
                newName: "IX_TableOccupancy_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_TableOccupancies_OrderId",
                table: "TableOccupancy",
                newName: "IX_TableOccupancy_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableOccupancy",
                table: "TableOccupancy",
                column: "TableOccupancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancy_Orders_OrderId",
                table: "TableOccupancy",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderNum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancy_Reservations_ReservationId",
                table: "TableOccupancy",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancy_Tables_TableId",
                table: "TableOccupancy",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableNum",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

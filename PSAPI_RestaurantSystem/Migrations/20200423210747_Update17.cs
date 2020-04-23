using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies");

            migrationBuilder.AddForeignKey(
                name: "FK_TableOccupancies_Reservations_ReservationId",
                table: "TableOccupancies",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservedByUserId",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservedByUserId",
                table: "Reservations",
                column: "ReservedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_ReservedByUserId",
                table: "Reservations",
                column: "ReservedByUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_ReservedByUserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservedByUserId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservedByUserId",
                table: "Reservations");
        }
    }
}

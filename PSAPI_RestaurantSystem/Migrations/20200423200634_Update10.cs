using Microsoft.EntityFrameworkCore.Migrations;

namespace PSAPIRestaurantSystem.Migrations
{
    public partial class Update10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegisteredByAdminId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RegisteredByAdminId",
                table: "Employees",
                column: "RegisteredByAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees",
                column: "RegisteredByAdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Admins_RegisteredByAdminId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RegisteredByAdminId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RegisteredByAdminId",
                table: "Employees");
        }
    }
}

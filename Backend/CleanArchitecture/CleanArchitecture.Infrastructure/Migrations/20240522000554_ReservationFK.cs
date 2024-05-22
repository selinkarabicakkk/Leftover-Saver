using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class ReservationFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Reservations_ReservationId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ReservationId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "ReservationCode",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_itemId",
                table: "Reservations",
                column: "itemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Items_itemId",
                table: "Reservations",
                column: "itemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Items_itemId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_itemId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationCode",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ReservationId",
                table: "Items",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Reservations_ReservationId",
                table: "Items",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }
    }
}

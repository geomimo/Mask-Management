using Microsoft.EntityFrameworkCore.Migrations;

namespace MaskManagement.Migrations
{
    public partial class RemovedCustomerFromPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Customers_CustomerId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Purchases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Customers_CustomerId",
                table: "Purchases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MaskManagement.Migrations
{
    public partial class AddedPurchaseType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseType",
                table: "Purchases",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseType",
                table: "Purchases");
        }
    }
}

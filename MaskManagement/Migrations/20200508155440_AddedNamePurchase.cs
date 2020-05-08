using Microsoft.EntityFrameworkCore.Migrations;

namespace MaskManagement.Migrations
{
    public partial class AddedNamePurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Purchases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Purchases");
        }
    }
}

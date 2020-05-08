using Microsoft.EntityFrameworkCore.Migrations;

namespace MaskManagement.Migrations
{
    public partial class FixedPurchaseRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedMasks_Purchases_PurchaseId",
                table: "PurchasedMasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasedMasks",
                table: "PurchasedMasks");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedMasks_PurchaseId",
                table: "PurchasedMasks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PurchasedMasks");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "PurchasedMasks");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Purchases",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PurchasedMasksId",
                table: "PurchasedMasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "PurchaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasedMasks",
                table: "PurchasedMasks",
                column: "PurchasedMasksId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedMasks_Purchases_PurchasedMasksId",
                table: "PurchasedMasks",
                column: "PurchasedMasksId",
                principalTable: "Purchases",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedMasks_Purchases_PurchasedMasksId",
                table: "PurchasedMasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasedMasks",
                table: "PurchasedMasks");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "PurchasedMasksId",
                table: "PurchasedMasks");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PurchasedMasks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "PurchasedMasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasedMasks",
                table: "PurchasedMasks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedMasks_PurchaseId",
                table: "PurchasedMasks",
                column: "PurchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedMasks_Purchases_PurchaseId",
                table: "PurchasedMasks",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

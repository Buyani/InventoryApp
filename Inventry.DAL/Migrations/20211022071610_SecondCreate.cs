using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventry.DAL.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsPurchaseOrders_ProductTypes_TypeProductId",
                table: "ProductsPurchaseOrders");

            migrationBuilder.RenameColumn(
                name: "TypeProductId",
                table: "ProductTypes",
                newName: "ProductTypeId");

            migrationBuilder.RenameColumn(
                name: "TypeProductId",
                table: "ProductsPurchaseOrders",
                newName: "TypeProductProductTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsPurchaseOrders_TypeProductId",
                table: "ProductsPurchaseOrders",
                newName: "IX_ProductsPurchaseOrders_TypeProductProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsPurchaseOrders_ProductTypes_TypeProductProductTypeId",
                table: "ProductsPurchaseOrders",
                column: "TypeProductProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsPurchaseOrders_ProductTypes_TypeProductProductTypeId",
                table: "ProductsPurchaseOrders");

            migrationBuilder.RenameColumn(
                name: "ProductTypeId",
                table: "ProductTypes",
                newName: "TypeProductId");

            migrationBuilder.RenameColumn(
                name: "TypeProductProductTypeId",
                table: "ProductsPurchaseOrders",
                newName: "TypeProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsPurchaseOrders_TypeProductProductTypeId",
                table: "ProductsPurchaseOrders",
                newName: "IX_ProductsPurchaseOrders_TypeProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsPurchaseOrders_ProductTypes_TypeProductId",
                table: "ProductsPurchaseOrders",
                column: "TypeProductId",
                principalTable: "ProductTypes",
                principalColumn: "TypeProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

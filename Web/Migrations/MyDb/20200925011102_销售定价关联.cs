using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 销售定价关联 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelSplitCost",
                table: "ProductSale");

            migrationBuilder.AddColumn<int>(
                name: "ModelSplitCostId",
                table: "ProductSale",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSale_ModelSplitCostId",
                table: "ProductSale",
                column: "ModelSplitCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSale_ModelSplitCost_ModelSplitCostId",
                table: "ProductSale",
                column: "ModelSplitCostId",
                principalTable: "ModelSplitCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSale_ModelSplitCost_ModelSplitCostId",
                table: "ProductSale");

            migrationBuilder.DropIndex(
                name: "IX_ProductSale_ModelSplitCostId",
                table: "ProductSale");

            migrationBuilder.DropColumn(
                name: "ModelSplitCostId",
                table: "ProductSale");

            migrationBuilder.AddColumn<int>(
                name: "ModelSplitCost",
                table: "ProductSale",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

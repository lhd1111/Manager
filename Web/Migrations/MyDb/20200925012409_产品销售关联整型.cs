using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 产品销售关联整型 : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

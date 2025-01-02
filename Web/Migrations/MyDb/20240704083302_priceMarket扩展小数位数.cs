using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class priceMarket扩展小数位数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceSum",
                table: "PriceMarket",
                type: "decimal(15, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceSum",
                table: "PriceMarket",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 4)");
        }
    }
}

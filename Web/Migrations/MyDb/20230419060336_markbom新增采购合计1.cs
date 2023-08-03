using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class markbom新增采购合计1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "cgTotal",
                table: "MarketBom",
                type: "decimal(7, 4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "cgTotal",
                table: "MarketBom",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7, 4)");
        }
    }
}

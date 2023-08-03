using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 撤销Total : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cgTotal",
                table: "MarketBom");

            migrationBuilder.AlterColumn<decimal>(
                name: "iPassRate",
                table: "MarketBom",
                type: "decimal(7, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "iPassRate",
                table: "MarketBom",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7, 2)");

            migrationBuilder.AddColumn<decimal>(
                name: "cgTotal",
                table: "MarketBom",
                type: "decimal(7, 4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

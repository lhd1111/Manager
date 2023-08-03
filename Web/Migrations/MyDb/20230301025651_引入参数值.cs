using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 引入参数值 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MachineValue",
                table: "PriceModel",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LineValue",
                table: "PriceDept",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProcessValue",
                table: "PriceDept",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineValue",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "LineValue",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "ProcessValue",
                table: "PriceDept");
        }
    }
}

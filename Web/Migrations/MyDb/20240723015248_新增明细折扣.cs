using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增明细折扣 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount1",
                table: "WgYcl",
                type: "decimal(5, 4)",
                nullable: false,
                defaultValue: 1.0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount1",
                table: "PricePacking",
                type: "decimal(5, 4)",
                nullable: false,
                defaultValue: 1.0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount1",
                table: "PriceModel",
                type: "decimal(5, 4)",
                nullable: false,
                defaultValue: 1.0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount1",
                table: "PriceDept",
                type: "decimal(5, 4)",
                nullable: false,
                defaultValue: 1.0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount1",
                table: "WgYcl");

            migrationBuilder.DropColumn(
                name: "Discount1",
                table: "PricePacking");

            migrationBuilder.DropColumn(
                name: "Discount1",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "Discount1",
                table: "PriceDept");
        }
    }
}

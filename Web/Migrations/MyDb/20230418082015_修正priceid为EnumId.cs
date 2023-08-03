using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正priceid为EnumId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "PriceMarket");

            migrationBuilder.AddColumn<int>(
                name: "EnumId",
                table: "PriceMarket",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnumId",
                table: "PriceMarket");

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "PriceMarket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class marketbom新增合格率 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "iModelLost",
                table: "MarketBom",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iPassRate",
                table: "MarketBom",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iModelLost",
                table: "MarketBom");

            migrationBuilder.DropColumn(
                name: "iPassRate",
                table: "MarketBom");
        }
    }
}

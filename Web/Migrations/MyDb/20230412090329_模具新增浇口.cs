using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具新增浇口 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "dcfs",
                table: "PriceModel",
                maxLength: 10,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "hkyg",
                table: "PriceModel",
                maxLength: 10,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "jksy",
                table: "PriceModel",
                maxLength: 10,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dcfs",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "hkyg",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "jksy",
                table: "PriceModel");
        }
    }
}

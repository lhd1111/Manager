using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增涂装损耗 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OfflinePerson",
                table: "PriceDept",
                type: "decimal(8, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sunhao",
                table: "PriceDept",
                type: "decimal(8, 4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfflinePerson",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "sunhao",
                table: "PriceDept");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改命名iGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iOrder",
                table: "PriceDept");

            migrationBuilder.AddColumn<int>(
                name: "iGroup",
                table: "PriceDept",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iGroup",
                table: "PriceDept");

            migrationBuilder.AddColumn<int>(
                name: "iOrder",
                table: "PriceDept",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

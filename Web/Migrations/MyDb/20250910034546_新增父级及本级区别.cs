using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增父级及本级区别 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pItemMaster",
                table: "Bao_GyUsed",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uLevel",
                table: "Bao_GyUsed",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pItemMaster",
                table: "Bao_GyUsed");

            migrationBuilder.DropColumn(
                name: "uLevel",
                table: "Bao_GyUsed");
        }
    }
}

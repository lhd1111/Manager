using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增零件编号 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvCode",
                table: "ThreePointDetail",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsPass",
                table: "ThreePointDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvCode",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "IsPass",
                table: "ThreePointDetail");
        }
    }
}

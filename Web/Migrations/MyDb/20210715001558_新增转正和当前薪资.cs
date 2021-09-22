using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增转正和当前薪资 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurMoney",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "zzhxzn",
                table: "Person",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurMoney",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "zzhxzn",
                table: "Person");
        }
    }
}

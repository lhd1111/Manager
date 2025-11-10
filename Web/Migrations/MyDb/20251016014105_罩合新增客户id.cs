using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 罩合新增客户id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustormerId",
                table: "ThreePoint",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDel",
                table: "ThreePoint",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustormerId",
                table: "ThreePoint");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "ThreePoint");
        }
    }
}

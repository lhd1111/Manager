using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 项目新增营销经理 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DevelopLevel",
                table: "ProjectList",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarketGh",
                table: "ProjectList",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarketName",
                table: "ProjectList",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DevelopLevel",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "MarketGh",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "MarketName",
                table: "ProjectList");
        }
    }
}

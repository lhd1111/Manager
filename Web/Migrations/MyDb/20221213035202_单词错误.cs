using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 单词错误 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descript",
                table: "ProjectPoint");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProjectPoint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProjectPoint");

            migrationBuilder.AddColumn<string>(
                name: "Descript",
                table: "ProjectPoint",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

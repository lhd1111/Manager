using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 审核标准单词错 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standardsck",
                table: "SystemCheck");

            migrationBuilder.AddColumn<string>(
                name: "Standard",
                table: "SystemCheck",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "SystemCheck");

            migrationBuilder.AddColumn<string>(
                name: "Standardsck",
                table: "SystemCheck",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

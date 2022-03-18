using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 统一责任人命名 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "personLiable",
                table: "ProjectTask");

            migrationBuilder.AddColumn<string>(
                name: "PersonName",
                table: "ProjectTask",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonName",
                table: "ProjectTask");

            migrationBuilder.AddColumn<string>(
                name: "personLiable",
                table: "ProjectTask",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}

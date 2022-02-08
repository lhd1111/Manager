using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 撤销试卷id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaperId",
                table: "PersonAnswer");

            migrationBuilder.DropColumn(
                name: "Socre",
                table: "PersonAnswer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaperId",
                table: "PersonAnswer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Socre",
                table: "PersonAnswer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

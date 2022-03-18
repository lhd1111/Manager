using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class code放置阶段 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "ProjectTask");

            migrationBuilder.AddColumn<string>(
                name: "stage",
                table: "ProjectTask",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stage",
                table: "ProjectTask");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "ProjectTask",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

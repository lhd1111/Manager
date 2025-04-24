using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 培训新增备注 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "RzTraining",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "RzTraining",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gh",
                table: "RzTraining",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "RzTraining");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "RzTraining");

            migrationBuilder.DropColumn(
                name: "gh",
                table: "RzTraining");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改入住 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Accommodation");

            migrationBuilder.AddColumn<string>(
                name: "gh",
                table: "Accommodation",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gh",
                table: "Accommodation");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Accommodation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

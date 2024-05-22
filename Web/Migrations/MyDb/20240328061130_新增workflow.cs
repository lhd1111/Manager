using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增workflow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TwoEnum",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Back",
                table: "TwoEnum",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Front",
                table: "TwoEnum",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gh",
                table: "TwoEnum",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TwoEnum");

            migrationBuilder.DropColumn(
                name: "Back",
                table: "TwoEnum");

            migrationBuilder.DropColumn(
                name: "Front",
                table: "TwoEnum");

            migrationBuilder.DropColumn(
                name: "gh",
                table: "TwoEnum");
        }
    }
}

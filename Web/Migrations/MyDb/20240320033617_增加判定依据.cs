using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 增加判定依据 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pd0",
                table: "ProjectHand",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pd2",
                table: "ProjectHand",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pd3",
                table: "ProjectHand",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pd4",
                table: "ProjectHand",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pd5",
                table: "ProjectHand",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pd0",
                table: "ProjectHand");

            migrationBuilder.DropColumn(
                name: "Pd2",
                table: "ProjectHand");

            migrationBuilder.DropColumn(
                name: "Pd3",
                table: "ProjectHand");

            migrationBuilder.DropColumn(
                name: "Pd4",
                table: "ProjectHand");

            migrationBuilder.DropColumn(
                name: "Pd5",
                table: "ProjectHand");
        }
    }
}

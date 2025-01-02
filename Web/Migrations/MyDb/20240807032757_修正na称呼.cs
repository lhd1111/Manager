using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正na称呼 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNa",
                table: "ProjectHand");

            migrationBuilder.AddColumn<bool>(
                name: "canNa",
                table: "ProjectHand",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "canNa",
                table: "ProjectHand");

            migrationBuilder.AddColumn<bool>(
                name: "IsNa",
                table: "ProjectHand",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增备注 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "ProjectHand",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectTaskId",
                table: "ProjectHand",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "ProjectHand");

            migrationBuilder.DropColumn(
                name: "ProjectTaskId",
                table: "ProjectHand");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增舍弃标志 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "taskName",
                table: "ProjectTask");

            migrationBuilder.AddColumn<bool>(
                name: "IsNa",
                table: "ProjectTask",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNa",
                table: "ProjectTask");

            migrationBuilder.AddColumn<string>(
                name: "taskName",
                table: "ProjectTask",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

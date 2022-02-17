using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 薪资类型更名 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryNum",
                table: "SalarySummary");

            migrationBuilder.AddColumn<string>(
                name: "SalaryType",
                table: "SalarySummary",
                maxLength: 3,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryType",
                table: "SalarySummary");

            migrationBuilder.AddColumn<string>(
                name: "SalaryNum",
                table: "SalarySummary",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);
        }
    }
}

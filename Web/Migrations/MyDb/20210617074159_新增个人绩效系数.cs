using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增个人绩效系数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fJx",
                table: "SalaryAttendance");

            migrationBuilder.AddColumn<float>(
                name: "F_15",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "F_15",
                table: "SalaryAttendance");

            migrationBuilder.AddColumn<float>(
                name: "fJx",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

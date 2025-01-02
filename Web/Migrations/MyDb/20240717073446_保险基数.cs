using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 保险基数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GjjJs",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YbJs",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GjjJs",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "YbJs",
                table: "SalaryAttendance");
        }
    }
}

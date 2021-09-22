using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 考勤归档新增二次嘉奖和效益绩效 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ecjj",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "xyxs",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ecjj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "xyxs",
                table: "SalaryAttendance");
        }
    }
}

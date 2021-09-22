using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增社保医保 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Gjj",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "HighTemperature",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Sb",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SbYb",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Yb",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gjj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "HighTemperature",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Sb",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "SbYb",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Yb",
                table: "SalaryAttendance");
        }
    }
}

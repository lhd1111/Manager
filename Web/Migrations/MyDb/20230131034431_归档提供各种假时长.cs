using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 归档提供各种假时长 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Bj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Cc",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Cj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Dxbj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Hj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Jb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Pcj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Prj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Sj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Sx",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "fjec",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "zjec",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Cc",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Cj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Dxbj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Hj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Jb",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Pcj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Prj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Sj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Sx",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Tq",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "fjec",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "zjec",
                table: "SalaryAttendance");
        }
    }
}

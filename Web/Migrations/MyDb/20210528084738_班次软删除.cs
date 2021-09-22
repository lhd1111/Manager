using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 班次软删除 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "F_48",
                table: "SalaryAttendance",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "F_114",
                table: "SalaryAttendance",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "cd",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "kqkf",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "zt",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "Frequency",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cd",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "kqkf",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "zt",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "Frequency");

            migrationBuilder.AlterColumn<bool>(
                name: "F_48",
                table: "SalaryAttendance",
                type: "bit",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "F_114",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 工资full为关键字 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Full",
                table: "SalaryAttendance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                table: "SalaryAttendance",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<float>(
                name: "iFull",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iFull",
                table: "SalaryAttendance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                table: "SalaryAttendance",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Full",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

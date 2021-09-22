using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增调休年假和总计 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmTime",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Nj",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Tx",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SalaryAttendance",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "workZc",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmTime",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Nj",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "Tx",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "workZc",
                table: "SalaryAttendance");
        }
    }
}

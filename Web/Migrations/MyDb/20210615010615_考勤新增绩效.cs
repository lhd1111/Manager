﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 考勤新增绩效 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "fJx",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fJx",
                table: "SalaryAttendance");
        }
    }
}

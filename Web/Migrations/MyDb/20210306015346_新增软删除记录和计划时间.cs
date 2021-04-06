using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增软删除记录和计划时间 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PlanDate",
                table: "SystemCheckResult",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "SystemCheck",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanDate",
                table: "SystemCheckResult");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "SystemCheck");
        }
    }
}

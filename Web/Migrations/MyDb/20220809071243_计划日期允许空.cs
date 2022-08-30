using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 计划日期允许空 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PlanDate",
                table: "ProjectProblem",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PlanDate",
                table: "ProjectProblem",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}

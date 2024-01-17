using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 部门新增软删除 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Department");

            migrationBuilder.AddColumn<DateTime>(
                name: "DelTime",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "Department",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelTime",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

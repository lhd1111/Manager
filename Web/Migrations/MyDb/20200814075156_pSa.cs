using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class pSa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Salaries",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Salaries",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "iOrder",
                table: "Salaries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "requestid",
                table: "Salaries",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "iOrder",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "requestid",
                table: "Salaries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Salaries",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}

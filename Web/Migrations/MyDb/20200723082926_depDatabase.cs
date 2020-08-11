using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class depDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Salaries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "rzrq",
                table: "Person",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "oGh",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rDataBase",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uDataBase",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "rzrq",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "oGh",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "rDataBase",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "uDataBase",
                table: "Department");
        }
    }
}

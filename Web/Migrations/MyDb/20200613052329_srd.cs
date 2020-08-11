using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class srd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iMonth",
                table: "SalesReport");

            migrationBuilder.DropColumn(
                name: "iYear",
                table: "SalesReport");

            migrationBuilder.AddColumn<DateTime>(
                name: "Period",
                table: "SalesReport",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "SalesReport");

            migrationBuilder.AddColumn<int>(
                name: "iMonth",
                table: "SalesReport",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iYear",
                table: "SalesReport",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

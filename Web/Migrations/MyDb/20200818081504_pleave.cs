using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class pleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Person");

            migrationBuilder.AddColumn<bool>(
                name: "IsTest",
                table: "Person",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "dLeaveDate",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTest",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "dLeaveDate",
                table: "Person");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Person",
                type: "datetime2",
                nullable: true);
        }
    }
}

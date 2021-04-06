using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 班次信息更新 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Frequency");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Frequency");

            migrationBuilder.AddColumn<string>(
                name: "IsCd",
                table: "Frequency",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxOvertime",
                table: "Frequency",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCd",
                table: "Frequency");

            migrationBuilder.DropColumn(
                name: "MaxOvertime",
                table: "Frequency");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Frequency",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Frequency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

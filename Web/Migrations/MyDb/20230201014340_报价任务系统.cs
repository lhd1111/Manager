using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 报价任务系统 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActualEndDate",
                table: "PriceCollection",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsClose",
                table: "PriceCollection",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PriceStatus",
                table: "PriceCollection",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pglxNote",
                table: "OaApply",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualEndDate",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "IsClose",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "PriceStatus",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "pglxNote",
                table: "OaApply");
        }
    }
}

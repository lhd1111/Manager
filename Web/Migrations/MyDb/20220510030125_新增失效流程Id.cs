using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增失效流程Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Invaildate",
                table: "FixedAsset");

            migrationBuilder.AddColumn<int>(
                name: "InvailId",
                table: "FixedAsset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvailId",
                table: "FixedAsset");

            migrationBuilder.AddColumn<DateTime>(
                name: "Invaildate",
                table: "FixedAsset",
                type: "datetime2",
                nullable: true);
        }
    }
}

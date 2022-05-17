using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增查验日期和购买金额 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CheckDate",
                table: "FixedAsset",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Money",
                table: "FixedAsset",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckDate",
                table: "FixedAsset");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "FixedAsset");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正身份证结束日期 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumberBackXY",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CardNumberXY",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumberValidlDate",
                table: "Person",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CardNumberValidlDate",
                table: "Person",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumberBackXY",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumberXY",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

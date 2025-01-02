using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 调整税收表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NianJin",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "OtherKou",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "Shangye",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "ShiYe",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "ShuiLv",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "SuSuan",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "YangLao",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "YangLaoYan",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "YiLiao",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "ZhuFang",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sJm",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sJxjy",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sLfzj",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sLjjc",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sMrsr",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sQt",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sSr",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sSy",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sYkjs",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sYns",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sYnssd",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sYyjs",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sZfdk",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sZv",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sZx",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "sZykc",
                table: "PersonTax");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NianJin",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtherKou",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Shangye",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShiYe",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShuiLv",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SuSuan",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YangLao",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YangLaoYan",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YiLiao",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZhuFang",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sJm",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sJxjy",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sLfzj",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sLjjc",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sMrsr",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sQt",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sSr",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sSy",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sYkjs",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sYns",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sYnssd",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sYyjs",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sZfdk",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sZv",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sZx",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "sZykc",
                table: "PersonTax",
                type: "decimal(8, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

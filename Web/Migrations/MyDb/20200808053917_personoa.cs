using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class personoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "U8Id",
                table: "Person",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "dlgzhz",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gh",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gwxj",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gzdd",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "htjs",
                table: "Person",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "htqs",
                table: "Person",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "jb",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lb",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rylb",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "xzdj",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ygxs",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zwdj",
                table: "Person",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "U8Id",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "dlgzhz",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "gh",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "gwxj",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "gzdd",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "htjs",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "htqs",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "jb",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "lb",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "rylb",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "xzdj",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ygxs",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "zwdj",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

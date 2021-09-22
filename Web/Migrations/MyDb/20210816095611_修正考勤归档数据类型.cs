using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正考勤归档数据类型 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "F_40",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "F_62",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "F_63",
                table: "SalaryAttendance");

            migrationBuilder.AlterColumn<decimal>(
                name: "zjCq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ybSum",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "xyxs",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "thingJ",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "sumColPiece",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "rzqq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "rcJb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "rcCq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "oaJl",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "oaJc",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "oaGf",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "oaCf",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "oPiece",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "lzqq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "lzTs",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "kqkf",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "kgqq",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "jrjbg",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "jrjb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "jqJb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "illJ",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "iQt",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "iFull",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ecjj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Yb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tx",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sb",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Piece",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Nj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "HighTemperature",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gjj",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_89",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_64",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_61",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_48",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_39",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_38",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_37",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_15",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_114",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_106",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "F_105",
                table: "SalaryAttendance",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "DataBaseId",
                table: "PersonTax",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Period",
                table: "PersonTax",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataBaseId",
                table: "PersonTax");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "PersonTax");

            migrationBuilder.AlterColumn<float>(
                name: "zjCq",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ybSum",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "xyxs",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "thingJ",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "sumColPiece",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "rzqq",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "rcJb",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "rcCq",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "oaJl",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "oaJc",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "oaGf",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "oaCf",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "oPiece",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "lzqq",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "lzTs",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "kqkf",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "kgqq",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "jrjbg",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "jrjb",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "jqJb",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "illJ",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "iQt",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "iFull",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ecjj",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Yb",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Tx",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Sb",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Piece",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Nj",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "HighTemperature",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Gjj",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_89",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_64",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_61",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_48",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_39",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_38",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_37",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_15",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "F_114",
                table: "SalaryAttendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_106",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "F_105",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AddColumn<float>(
                name: "F_40",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "F_62",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "F_63",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

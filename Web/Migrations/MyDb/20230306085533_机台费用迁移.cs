using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 机台费用迁移 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "MachineValue",
                table: "PriceModel");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "LineName",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "LineValue",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "ProcessId",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "ProcessName",
                table: "PriceDept");

            migrationBuilder.RenameColumn(
                name: "ProcessValue",
                table: "PriceDept",
                newName: "MachineValue");

            migrationBuilder.AddColumn<string>(
                name: "FrockName",
                table: "PriceDept",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "PriceDept",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "PriceDept",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrockName",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "PriceDept");

            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "PriceDept");

            migrationBuilder.RenameColumn(
                name: "MachineValue",
                table: "PriceDept",
                newName: "ProcessValue");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "PriceModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "PriceModel",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MachineValue",
                table: "PriceModel",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "PriceDept",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LineName",
                table: "PriceDept",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LineValue",
                table: "PriceDept",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProcessId",
                table: "PriceDept",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProcessName",
                table: "PriceDept",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}

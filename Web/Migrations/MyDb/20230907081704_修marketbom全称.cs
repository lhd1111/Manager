using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修marketbom全称 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WgYcl");

            migrationBuilder.DropColumn(
                name: "IsComing",
                table: "Reception");

            migrationBuilder.DropColumn(
                name: "IsOut",
                table: "Reception");

            migrationBuilder.AlterColumn<decimal>(
                name: "MachineValue",
                table: "PriceDept",
                type: "decimal(8, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "MarketBom",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "MarketBom");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WgYcl",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsComing",
                table: "Reception",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IsOut",
                table: "Reception",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "MachineValue",
                table: "PriceDept",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 4)");
        }
    }
}

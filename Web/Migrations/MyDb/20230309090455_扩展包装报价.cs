using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 扩展包装报价 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PackingCost",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ContainerCost",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AftersalesService",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LogisticCost",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Others",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "StorageFee",
                table: "PricePacking",
                type: "decimal(7, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TranportationCost",
                table: "PricePacking",
                type: "decimal(17, 4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AftersalesService",
                table: "PricePacking");

            migrationBuilder.DropColumn(
                name: "LogisticCost",
                table: "PricePacking");

            migrationBuilder.DropColumn(
                name: "Others",
                table: "PricePacking");

            migrationBuilder.DropColumn(
                name: "StorageFee",
                table: "PricePacking");

            migrationBuilder.DropColumn(
                name: "TranportationCost",
                table: "PricePacking");

            migrationBuilder.AlterColumn<string>(
                name: "PackingCost",
                table: "PricePacking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7, 4)");

            migrationBuilder.AlterColumn<string>(
                name: "ContainerCost",
                table: "PricePacking",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7, 4)");
        }
    }
}

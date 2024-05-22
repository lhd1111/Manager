using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class rowsum扩位 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "WgYcl",
                type: "decimal(12, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceMarket",
                type: "decimal(12, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceDept",
                type: "decimal(12, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "WgYcl",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceMarket",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceDept",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12, 4)");
        }
    }
}

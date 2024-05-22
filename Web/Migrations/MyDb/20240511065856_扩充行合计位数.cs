using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 扩充行合计位数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "WgYcl",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceDept",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "WgYcl",
                type: "decimal(6, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RowSummary",
                table: "PriceDept",
                type: "decimal(6, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");
        }
    }
}

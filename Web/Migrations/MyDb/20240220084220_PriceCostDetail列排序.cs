using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class PriceCostDetail列排序 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "iValue",
                table: "PriceCostDetail",
                type: "decimal(15, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AddColumn<int>(
                name: "iOrder",
                table: "PriceCostDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iOrder",
                table: "PriceCostDetail");

            migrationBuilder.AlterColumn<decimal>(
                name: "iValue",
                table: "PriceCostDetail",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 4)");
        }
    }
}

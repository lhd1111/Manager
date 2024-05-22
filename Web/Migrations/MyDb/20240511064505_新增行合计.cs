using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增行合计 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RowSummary",
                table: "WgYcl",
                type: "decimal(6, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RowSummary",
                table: "PriceDept",
                type: "decimal(6, 4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowSummary",
                table: "WgYcl");

            migrationBuilder.DropColumn(
                name: "RowSummary",
                table: "PriceDept");
        }
    }
}

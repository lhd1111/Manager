using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 人工成本新增销售额 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "SaleMoney",
                table: "LaborCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "SummaryType",
                table: "LaborCost",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleMoney",
                table: "LaborCost");

            migrationBuilder.DropColumn(
                name: "SummaryType",
                table: "LaborCost");
        }
    }
}

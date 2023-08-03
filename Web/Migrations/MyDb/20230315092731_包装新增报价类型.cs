using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 包装新增报价类型 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeptType",
                table: "PricePacking",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Number",
                table: "OaApply",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptType",
                table: "PricePacking");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "OaApply",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");
        }
    }
}

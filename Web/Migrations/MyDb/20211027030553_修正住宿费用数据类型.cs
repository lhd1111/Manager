using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正住宿费用数据类型 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "zj",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ZhuSu",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShuiFei",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "QingJieFei",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "QiTaFei",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "QiFei",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "DianFei",
                table: "LivingCost",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "zj",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ZhuSu",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ShuiFei",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "QingJieFei",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "QiTaFei",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "QiFei",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "DianFei",
                table: "LivingCost",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正小数位数错误 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "sProductPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "sPersonPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "sMachine",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 4)");

            migrationBuilder.AlterColumn<float>(
                name: "SumPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "SingleUsage",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ProductPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 4)");

            migrationBuilder.AlterColumn<float>(
                name: "PersonPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 4)");

            migrationBuilder.AlterColumn<float>(
                name: "OtherPrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 4)");

            migrationBuilder.AlterColumn<float>(
                name: "OneIncome",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "MichinePrice",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 4)");

            migrationBuilder.AlterColumn<float>(
                name: "Income",
                table: "PriceSelling",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "sProductPrice",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "sPersonPrice",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "sMachine",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "PriceSelling",
                type: "decimal(4, 4)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "SumPrice",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "SingleUsage",
                table: "PriceSelling",
                type: "decimal(3, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "PriceSelling",
                type: "decimal(4, 4)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "PersonPrice",
                table: "PriceSelling",
                type: "decimal(4, 4)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherPrice",
                table: "PriceSelling",
                type: "decimal(4, 4)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "OneIncome",
                table: "PriceSelling",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "MichinePrice",
                table: "PriceSelling",
                type: "decimal(4, 4)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}

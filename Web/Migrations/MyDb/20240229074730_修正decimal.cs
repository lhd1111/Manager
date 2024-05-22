using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正decimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHand",
                table: "ProjectTask",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "sProductPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "sPersonPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "sMachine",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice1",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "SumPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "SingleUsage",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "SingleNumber",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "PersonPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "OtherPrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "OneIncome",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "MichinePrice",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "PriceSelling",
                type: "decimal(15, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHand",
                table: "ProjectTask");

            migrationBuilder.AlterColumn<float>(
                name: "sProductPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "sPersonPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "sMachine",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice1",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "SumPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "SingleUsage",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "SingleNumber",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "ProductPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "PersonPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "OtherPrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "OneIncome",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "MichinePrice",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");

            migrationBuilder.AlterColumn<float>(
                name: "Income",
                table: "PriceSelling",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15, 2)");
        }
    }
}

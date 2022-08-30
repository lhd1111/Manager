using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正表值为字符串 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value7",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value6",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value5",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value4",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value3",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value2",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value1",
                table: "CheckDetail",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Value7",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value6",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value5",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value4",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value3",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value2",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value1",
                table: "CheckDetail",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}

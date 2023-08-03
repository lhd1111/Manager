using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增喷涂类型 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PtNumber",
                table: "PricePt",
                type: "decimal(10, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PtName",
                table: "PricePt",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtType",
                table: "PricePt",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PtName",
                table: "PricePt");

            migrationBuilder.DropColumn(
                name: "PtType",
                table: "PricePt");

            migrationBuilder.AlterColumn<int>(
                name: "PtNumber",
                table: "PricePt",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 2)");
        }
    }
}

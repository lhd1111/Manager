using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具预算金额为整数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BudgetAmount",
                table: "PriceModel",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.CreateTable(
                name: "PricePt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    PtSum = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PtCost = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PtNumber = table.Column<int>(nullable: false),
                    EnumId = table.Column<int>(nullable: false),
                    BomId = table.Column<int>(nullable: false),
                    PriceCollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricePt", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricePt");

            migrationBuilder.AlterColumn<decimal>(
                name: "BudgetAmount",
                table: "PriceModel",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 食堂菜单 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PtSum",
                table: "PricePt",
                type: "decimal(10, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "MarketBom",
                type: "decimal(8,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.CreateTable(
                name: "CanteeMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    DishType = table.Column<string>(nullable: true),
                    DishName = table.Column<string>(maxLength: 20, nullable: true),
                    IsCg = table.Column<bool>(nullable: false),
                    SmallPrice = table.Column<int>(nullable: false),
                    BigPrice = table.Column<int>(nullable: false),
                    DishNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanteeMenu", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanteeMenu");

            migrationBuilder.AlterColumn<decimal>(
                name: "PtSum",
                table: "PricePt",
                type: "decimal(10, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "MarketBom",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)");
        }
    }
}

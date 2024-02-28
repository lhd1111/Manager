using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改客户指定为模具费用 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SZ",
                table: "WgYcl");

            migrationBuilder.AddColumn<int>(
                name: "ModelCg",
                table: "WgYcl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PriceSale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    SingleUsage = table.Column<decimal>(type: "decimal(3, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    SumPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    OtherPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    OtherNumber = table.Column<int>(nullable: false),
                    Income = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    OneIncome = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    sProductPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    PersonPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    sPersonPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    MichinePrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    sMachine = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    PartType = table.Column<string>(maxLength: 5, nullable: true),
                    DeptType = table.Column<string>(maxLength: 5, nullable: true),
                    BomId = table.Column<int>(nullable: false),
                    PriceCollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSale", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceSale");

            migrationBuilder.DropColumn(
                name: "ModelCg",
                table: "WgYcl");

            migrationBuilder.AddColumn<string>(
                name: "SZ",
                table: "WgYcl",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);
        }
    }
}

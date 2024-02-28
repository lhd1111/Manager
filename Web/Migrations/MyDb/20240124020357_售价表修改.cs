using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 售价表修改 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceSale");

            migrationBuilder.CreateTable(
                name: "PriceSelling",
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
                    table.PrimaryKey("PK_PriceSelling", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceSelling");

            migrationBuilder.CreateTable(
                name: "PriceSale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DeptType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Income = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    MichinePrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    ModifyTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OneIncome = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    OtherNumber = table.Column<int>(type: "int", nullable: false),
                    OtherPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    PartType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PersonPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    PriceCollectionId = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    SingleUsage = table.Column<decimal>(type: "decimal(3, 2)", nullable: false),
                    SumPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(4, 4)", nullable: false),
                    sMachine = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    sPersonPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    sProductPrice = table.Column<decimal>(type: "decimal(4, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSale", x => x.Id);
                });
        }
    }
}

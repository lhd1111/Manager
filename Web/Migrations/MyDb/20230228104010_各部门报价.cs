using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 各部门报价 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceDept",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    DirectLabor = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    Period = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    PassRate = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    FrockNumber = table.Column<int>(nullable: false),
                    ManhourRate = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    MachineRate = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    DeptType = table.Column<string>(maxLength: 5, nullable: true),
                    LineName = table.Column<string>(maxLength: 20, nullable: true),
                    ProcessName = table.Column<string>(maxLength: 20, nullable: true),
                    ProcessId = table.Column<int>(nullable: false),
                    LineId = table.Column<int>(nullable: false),
                    BomId = table.Column<int>(nullable: false),
                    PriceCollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceDept", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceDept");
        }
    }
}

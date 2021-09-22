using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增扣税表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTax",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    CardNumber = table.Column<string>(maxLength: 18, nullable: true),
                    Sr = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Fy = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Mrsr = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    YangLao = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    YiLiao = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ShiYe = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ZhuFang = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    NianJin = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Shangye = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    YangLaoYan = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    OtherKou = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sSr = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sMrsr = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sLjjc = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sZx = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sZv = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sJxjy = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sZfdk = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sLfzj = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sSy = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sQt = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sZykc = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sYnssd = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ShuiLv = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    SuSuan = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sYns = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sJm = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sYkjs = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sYyjs = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    sYbts = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTax", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonTax");
        }
    }
}

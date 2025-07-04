using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 供应商扫码界面 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendorScan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ScanStr = table.Column<string>(nullable: true),
                    cInvCode = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(20, 6)", nullable: false),
                    Num = table.Column<string>(nullable: true),
                    VendorId = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Prt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorScan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorScan");
        }
    }
}

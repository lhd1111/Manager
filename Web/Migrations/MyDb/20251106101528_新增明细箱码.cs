using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增明细箱码 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "VendorScan",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20, 6)");

            migrationBuilder.CreateTable(
                name: "VendorScans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ScanStr = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Num = table.Column<string>(nullable: true),
                    VendorScanId = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorScans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorScans");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "VendorScan",
                type: "decimal(20, 6)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}

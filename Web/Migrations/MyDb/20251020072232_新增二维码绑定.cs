using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增二维码绑定 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ePeriod",
                table: "Bao_gy");

            migrationBuilder.AddColumn<string>(
                name: "pQRCode",
                table: "Bao_GyUsed",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eType",
                table: "Bao_gy",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "QRSCBind",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    zQRCode = table.Column<string>(nullable: true),
                    fQRCode = table.Column<string>(nullable: true),
                    Org = table.Column<string>(nullable: true),
                    IsDel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRSCBind", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QRSCBind");

            migrationBuilder.DropColumn(
                name: "pQRCode",
                table: "Bao_GyUsed");

            migrationBuilder.DropColumn(
                name: "eType",
                table: "Bao_gy");

            migrationBuilder.AddColumn<int>(
                name: "ePeriod",
                table: "Bao_gy",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

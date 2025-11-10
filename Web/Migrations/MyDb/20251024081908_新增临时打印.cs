using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增临时打印 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempCode",
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
                    cInvName = table.Column<string>(nullable: true),
                    cInvCodeAll = table.Column<string>(nullable: true),
                    cInvNameAll = table.Column<string>(nullable: true),
                    Batch = table.Column<string>(maxLength: 8, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Num = table.Column<string>(nullable: true),
                    Org = table.Column<string>(nullable: true),
                    ItemMaster = table.Column<string>(nullable: true),
                    Mo = table.Column<string>(nullable: true),
                    DocNo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Prt = table.Column<int>(nullable: false),
                    type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempCode", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempCode");
        }
    }
}

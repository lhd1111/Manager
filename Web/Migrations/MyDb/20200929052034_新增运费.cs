using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增运费 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesFreight",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    cCusCode = table.Column<string>(maxLength: 20, nullable: true),
                    cCusName = table.Column<string>(maxLength: 98, nullable: true),
                    cInvCode = table.Column<string>(maxLength: 120, nullable: true),
                    cInvName = table.Column<string>(maxLength: 510, nullable: true),
                    cInvStd = table.Column<string>(maxLength: 50, nullable: true),
                    fPacking = table.Column<float>(nullable: false),
                    fFreight = table.Column<float>(nullable: false),
                    fOtherFreight = table.Column<float>(nullable: false),
                    Note = table.Column<string>(maxLength: 200, nullable: true),
                    uDataBase = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesFreight", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesFreight");
        }
    }
}

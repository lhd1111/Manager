using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增来访登记 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reception",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    personNameB = table.Column<string>(nullable: true),
                    personMobileB = table.Column<string>(nullable: true),
                    personName = table.Column<string>(nullable: true),
                    personMobile = table.Column<string>(nullable: true),
                    personNumer = table.Column<string>(nullable: true),
                    strartTime = table.Column<DateTime>(nullable: false),
                    personReason = table.Column<string>(nullable: true),
                    carNo = table.Column<string>(nullable: true),
                    IsAngree = table.Column<string>(nullable: false),
                    IsComing = table.Column<string>(nullable: false),
                    IsOut = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reception", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reception");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 考勤归档 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaryAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Period = table.Column<DateTime>(nullable: false),
                    gh = table.Column<string>(maxLength: 20, nullable: true),
                    rcCq = table.Column<float>(nullable: false),
                    F_37 = table.Column<float>(nullable: false),
                    zjCq = table.Column<float>(nullable: false),
                    F_63 = table.Column<float>(nullable: false),
                    F_89 = table.Column<float>(nullable: false),
                    rcJb = table.Column<float>(nullable: false),
                    F_38 = table.Column<float>(nullable: false),
                    F_62 = table.Column<float>(nullable: false),
                    jqJb = table.Column<float>(nullable: false),
                    F_39 = table.Column<float>(nullable: false),
                    F_98 = table.Column<float>(nullable: false),
                    ybSum = table.Column<float>(nullable: false),
                    F_40 = table.Column<float>(nullable: false),
                    F_64 = table.Column<float>(nullable: false),
                    F_61 = table.Column<float>(nullable: false),
                    thingJ = table.Column<float>(nullable: false),
                    F_105 = table.Column<float>(nullable: false),
                    illJ = table.Column<float>(nullable: false),
                    F_106 = table.Column<float>(nullable: false),
                    sumColPiece = table.Column<float>(nullable: false),
                    F_111 = table.Column<float>(nullable: false),
                    F_114 = table.Column<float>(nullable: false),
                    F_112 = table.Column<float>(nullable: false),
                    IsFull = table.Column<bool>(nullable: false),
                    F_48 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryAttendance", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaryAttendance");
        }
    }
}

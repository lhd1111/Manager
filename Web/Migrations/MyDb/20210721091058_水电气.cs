using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 水电气 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "iQt",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "oaGf",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "LivingCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    gh = table.Column<string>(maxLength: 10, nullable: true),
                    Period = table.Column<DateTime>(nullable: false),
                    DataBaseId = table.Column<string>(maxLength: 3, nullable: true),
                    SuSheName = table.Column<string>(maxLength: 10, nullable: true),
                    BanZhi = table.Column<string>(maxLength: 10, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ZhuSu = table.Column<float>(nullable: false),
                    ShuiFei = table.Column<float>(nullable: false),
                    DianFei = table.Column<float>(nullable: false),
                    QiFei = table.Column<float>(nullable: false),
                    QingJieFei = table.Column<float>(nullable: false),
                    zj = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingCost", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivingCost");

            migrationBuilder.DropColumn(
                name: "iQt",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "oaGf",
                table: "SalaryAttendance");
        }
    }
}

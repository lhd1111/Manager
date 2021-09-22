using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增文件上传属性 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "SystemCheck");

            migrationBuilder.AddColumn<float>(
                name: "jrjb",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "jrjbg",
                table: "SalaryAttendance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "UpLoadFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 60, nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false),
                    SystemCheckResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpLoadFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpLoadFile_SystemCheckResult_SystemCheckResultId",
                        column: x => x.SystemCheckResultId,
                        principalTable: "SystemCheckResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UpLoadFile_SystemCheckResultId",
                table: "UpLoadFile",
                column: "SystemCheckResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpLoadFile");

            migrationBuilder.DropColumn(
                name: "jrjb",
                table: "SalaryAttendance");

            migrationBuilder.DropColumn(
                name: "jrjbg",
                table: "SalaryAttendance");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "SystemCheck",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

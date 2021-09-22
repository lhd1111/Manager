using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改系统检测的图片存储关联 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpLoadFile_SystemCheckResult_SystemCheckResultId",
                table: "UpLoadFile");

            migrationBuilder.DropIndex(
                name: "IX_UpLoadFile_SystemCheckResultId",
                table: "UpLoadFile");

            migrationBuilder.DropColumn(
                name: "SystemCheckResultId",
                table: "UpLoadFile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SystemCheckResultId",
                table: "UpLoadFile",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UpLoadFile_SystemCheckResultId",
                table: "UpLoadFile",
                column: "SystemCheckResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpLoadFile_SystemCheckResult_SystemCheckResultId",
                table: "UpLoadFile",
                column: "SystemCheckResultId",
                principalTable: "SystemCheckResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 重新调整问题 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Submitter",
                table: "ProjectProblem");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "ProjectProblem",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "ProjectProblem",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Submitter",
                table: "ProjectProblem",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}

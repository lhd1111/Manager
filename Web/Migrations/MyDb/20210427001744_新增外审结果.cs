using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增外审结果 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Analysis",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "DepartmentStrs",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "KeyPoint",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "ProblemType",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "Solution",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "SystemCheckName",
                table: "ExternalCheck");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ExternalCheck");

            migrationBuilder.CreateTable(
                name: "ExternalCheckResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ProblemType = table.Column<string>(maxLength: 2, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Analysis = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    SystemCheckName = table.Column<string>(nullable: true),
                    KeyPoint = table.Column<string>(nullable: true),
                    DepartmentStrs = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    IsClosed = table.Column<string>(maxLength: 1, nullable: true),
                    ExternalCheckId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalCheckResult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalCheckResult");

            migrationBuilder.AddColumn<string>(
                name: "Analysis",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentStrs",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsClosed",
                table: "ExternalCheck",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyPoint",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProblemType",
                table: "ExternalCheck",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Solution",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemCheckName",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ExternalCheck",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

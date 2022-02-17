using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 薪资吻 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalarySummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    Period = table.Column<DateTime>(nullable: false),
                    SalaryNum = table.Column<string>(maxLength: 3, nullable: true),
                    SalaryName = table.Column<string>(maxLength: 10, nullable: true),
                    SalaryCount = table.Column<int>(nullable: false),
                    SalaryError = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarySummary", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalarySummary");
        }
    }
}

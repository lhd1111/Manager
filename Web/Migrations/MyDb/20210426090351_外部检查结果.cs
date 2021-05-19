using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 外部检查结果 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExternalCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    CheckDate = table.Column<DateTime>(nullable: false),
                    Customer = table.Column<string>(maxLength: 50, nullable: true),
                    Project = table.Column<string>(maxLength: 50, nullable: true),
                    ProblemType = table.Column<string>(maxLength: 2, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Analysis = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    SystemCheckName = table.Column<string>(nullable: true),
                    KeyPoint = table.Column<string>(nullable: true),
                    DepartmentStrs = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    IsClosed = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalCheck", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalCheck");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 项目列表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ProjectName = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CarType = table.Column<string>(maxLength: 50, nullable: true),
                    NavForeign = table.Column<string>(maxLength: 50, nullable: true),
                    PersonName = table.Column<string>(maxLength: 20, nullable: true),
                    gh = table.Column<string>(maxLength: 20, nullable: true),
                    Ver = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: true),
                    InvestAddr = table.Column<string>(maxLength: 50, nullable: true),
                    Dimensional = table.Column<string>(maxLength: 50, nullable: true),
                    InvestDate = table.Column<DateTime>(maxLength: 50, nullable: false),
                    canWrite = table.Column<bool>(nullable: false),
                    canWriteOnParent = table.Column<bool>(nullable: false),
                    changesReasonWhy = table.Column<string>(nullable: true),
                    tasks = table.Column<int>(nullable: false),
                    zoom = table.Column<string>(nullable: true),
                    PlanStartDate = table.Column<DateTime>(nullable: false),
                    PlanEndDate = table.Column<DateTime>(nullable: false),
                    ActualStartDate = table.Column<DateTime>(nullable: true),
                    ActualEndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectList");
        }
    }
}

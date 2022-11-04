using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 经验库1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    LLR = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(maxLength: 50, nullable: true),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: true),
                    ProblemSource = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true),
                    ProblemClass = table.Column<string>(nullable: true),
                    KeyPoint = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    gh = table.Column<string>(maxLength: 20, nullable: true),
                    DepartmentStr = table.Column<string>(nullable: true),
                    OccurrencePlace = table.Column<string>(nullable: true),
                    OccurrenceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experience");
        }
    }
}

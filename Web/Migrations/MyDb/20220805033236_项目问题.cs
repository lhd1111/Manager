using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 项目问题 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectProblem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Scope = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 5, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    responsibility = table.Column<string>(maxLength: 20, nullable: true),
                    PersonName = table.Column<string>(maxLength: 20, nullable: true),
                    gh = table.Column<string>(maxLength: 10, nullable: true),
                    PlanDate = table.Column<DateTime>(nullable: false),
                    CloseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProblem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProblem_ProjectProblem_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProjectProblem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProblem_ParentId",
                table: "ProjectProblem",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectProblem");
        }
    }
}

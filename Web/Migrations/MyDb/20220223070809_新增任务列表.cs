using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增任务列表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CloseStatus",
                table: "ProjectList",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsClose",
                table: "ProjectList",
                maxLength: 10,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sReturn",
                table: "Person",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Scope = table.Column<string>(maxLength: 100, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    taskName = table.Column<string>(nullable: true),
                    progress = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    progressByWorklog = table.Column<string>(nullable: true),
                    relevance = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    typeId = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    status = table.Column<string>(maxLength: 13, nullable: true),
                    depends = table.Column<string>(nullable: true),
                    canWrite = table.Column<string>(maxLength: 5, nullable: true),
                    PlanStartDate = table.Column<DateTime>(nullable: false),
                    PlanEndDate = table.Column<DateTime>(nullable: false),
                    ActualStartDate = table.Column<DateTime>(nullable: true),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    duration = table.Column<int>(nullable: false),
                    startIsMilestone = table.Column<string>(nullable: true),
                    endIsMilestone = table.Column<string>(nullable: true),
                    collapsed = table.Column<string>(maxLength: 5, nullable: true),
                    hasChild = table.Column<string>(maxLength: 5, nullable: true),
                    responsibility = table.Column<string>(maxLength: 10, nullable: true),
                    personLiable = table.Column<string>(maxLength: 20, nullable: true),
                    gh = table.Column<string>(maxLength: 10, nullable: true),
                    iOrder = table.Column<int>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTask_ProjectTask_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProjectTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTask_ParentId",
                table: "ProjectTask",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTask");

            migrationBuilder.DropColumn(
                name: "CloseStatus",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "IsClose",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "sReturn",
                table: "Person");
        }
    }
}

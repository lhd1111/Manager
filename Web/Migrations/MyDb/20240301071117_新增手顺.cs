using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增手顺 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectHand",
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
                    Alias = table.Column<string>(maxLength: 100, nullable: true),
                    stage = table.Column<string>(maxLength: 20, nullable: true),
                    responsibility = table.Column<string>(maxLength: 20, nullable: true),
                    HandKind = table.Column<int>(nullable: false),
                    KeyPoint = table.Column<string>(maxLength: 100, nullable: true),
                    iOrder = table.Column<int>(nullable: false),
                    ProjectTask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectHand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectHand_ProjectHand_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProjectHand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectHand_ParentId",
                table: "ProjectHand",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectHand");
        }
    }
}

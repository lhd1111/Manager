using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CustomName = table.Column<string>(maxLength: 50, nullable: true),
                    ProductCode = table.Column<string>(maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(maxLength: 50, nullable: true),
                    Stage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            

           

            migrationBuilder.CreateTable(
                name: "Bom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(nullable: true),
                    FsCode = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Scope = table.Column<string>(maxLength: 50, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Path = table.Column<string>(maxLength: 100, nullable: true),
                    iOrder = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    CustomCode = table.Column<string>(maxLength: 50, nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    GrossWeight = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    Paint = table.Column<string>(maxLength: 50, nullable: true),
                    Surface = table.Column<string>(maxLength: 50, nullable: true),
                    Specs = table.Column<string>(maxLength: 50, nullable: true),
                    Tooling = table.Column<string>(maxLength: 50, nullable: true),
                    Material = table.Column<string>(maxLength: 50, nullable: true),
                    ModleCavity = table.Column<string>(maxLength: 50, nullable: true),
                    MakeMothod = table.Column<string>(maxLength: 1, nullable: true),
                    Characteristic = table.Column<string>(maxLength: 50, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bom_Bom_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Bom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bom_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bom_ParentId",
                table: "Bom",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bom_ProjectId",
                table: "Bom",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bom");

            migrationBuilder.DropTable(
                name: "Rd_Month_Pool");

            migrationBuilder.DropTable(
                name: "Rd_Pool");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}

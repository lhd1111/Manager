using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 包覆工艺配置 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bao_gy",
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
                    Org = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(maxLength: 50, nullable: true),
                    CodeId = table.Column<string>(nullable: true),
                    zPeriod = table.Column<int>(nullable: false),
                    uPeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bao_gy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bao_gy_Bao_gy_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Bao_gy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bao_gy_ParentId",
                table: "Bao_gy",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bao_gy");
        }
    }
}

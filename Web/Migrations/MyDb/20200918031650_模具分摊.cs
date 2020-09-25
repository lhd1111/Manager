using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具分摊 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelSplitCosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    cInvCode = table.Column<string>(maxLength: 120, nullable: true),
                    cInvName = table.Column<string>(maxLength: 510, nullable: true),
                    cInvStd = table.Column<string>(maxLength: 50, nullable: true),
                    sProject = table.Column<string>(maxLength: 50, nullable: true),
                    sGroup = table.Column<string>(nullable: true),
                    fModelCost = table.Column<float>(nullable: false),
                    iModelNum = table.Column<int>(nullable: false),
                    fPrice = table.Column<float>(nullable: false),
                    iModelNumed = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 200, nullable: true),
                    IsTest = table.Column<bool>(nullable: false),
                    uDataBase = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelSplitCosts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelSplitCosts");
        }
    }
}

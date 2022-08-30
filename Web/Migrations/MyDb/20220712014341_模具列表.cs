using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具列表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModelNum = table.Column<string>(maxLength: 20, nullable: true),
                    ModelName = table.Column<string>(maxLength: 50, nullable: true),
                    ModelType = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    MachineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelList");
        }
    }
}

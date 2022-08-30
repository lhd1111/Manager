using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增标准更替表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelDetailId",
                table: "ModelDetail");

            migrationBuilder.AddColumn<int>(
                name: "rModelDetailId",
                table: "ModelDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StandardHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModelDetailId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardHistory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StandardHistory");

            migrationBuilder.DropColumn(
                name: "rModelDetailId",
                table: "ModelDetail");

            migrationBuilder.AddColumn<int>(
                name: "ModelDetailId",
                table: "ModelDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 问答库 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "PostQuestion");

            migrationBuilder.DropColumn(
                name: "Score1",
                table: "PostQuestion");

            migrationBuilder.DropColumn(
                name: "gh",
                table: "PostQuestion");

            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "PostQuestion",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PostResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Type = table.Column<string>(nullable: true),
                    TableName = table.Column<string>(nullable: true),
                    TableId = table.Column<int>(nullable: false),
                    gh = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Score1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostResult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostResult");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "PostQuestion");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "PostQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score1",
                table: "PostQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gh",
                table: "PostQuestion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

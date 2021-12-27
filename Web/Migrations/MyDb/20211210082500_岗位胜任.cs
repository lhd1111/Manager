using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 岗位胜任 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumberBackXY",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CardNumberValidfDate",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CardNumberValidlDate",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumberXY",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostModel");

            migrationBuilder.DropColumn(
                name: "CardNumberBackXY",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CardNumberValidfDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CardNumberValidlDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CardNumberXY",
                table: "Person");
        }
    }
}

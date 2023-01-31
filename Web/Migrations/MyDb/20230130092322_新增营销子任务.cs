using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增营销子任务 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nbbh",
                table: "OaApply",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "PriceCollection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Ver = table.Column<int>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    PlanStartDate = table.Column<DateTime>(nullable: true),
                    PlanEndDate = table.Column<DateTime>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 20, nullable: true),
                    PersonGh = table.Column<string>(maxLength: 20, nullable: true),
                    requestId = table.Column<int>(nullable: false),
                    OaApplyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCollection", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceCollection");

            migrationBuilder.AlterColumn<int>(
                name: "nbbh",
                table: "OaApply",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class person新增车牌号和银行信息 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankCardNumber",
                table: "Person",
                maxLength: 19,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarNumber",
                table: "Person",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyBank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    dwId = table.Column<int>(maxLength: 98, nullable: false),
                    dwStr = table.Column<string>(maxLength: 98, nullable: true),
                    BankName = table.Column<string>(maxLength: 98, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBank", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyBank");

            migrationBuilder.DropColumn(
                name: "BankCardNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CarNumber",
                table: "Person");
        }
    }
}

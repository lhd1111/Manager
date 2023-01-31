using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 付款合同 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "Menu",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PurchaseContract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ContractNumber = table.Column<string>(nullable: true),
                    ContractA = table.Column<int>(nullable: false),
                    ContractB = table.Column<int>(nullable: false),
                    ContractType = table.Column<string>(nullable: true),
                    ContractDate = table.Column<DateTime>(nullable: false),
                    ContractMoney = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Note = table.Column<string>(nullable: true),
                    ContractGh = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    PayMoney = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PayDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PayStatus = table.Column<string>(nullable: true),
                    PayGh = table.Column<string>(maxLength: 20, nullable: true),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetail", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseContract");

            migrationBuilder.DropTable(
                name: "PurchaseDetail");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "Menu");
        }
    }
}

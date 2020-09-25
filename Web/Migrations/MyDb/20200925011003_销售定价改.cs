using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 销售定价改 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cCode",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cPTCode",
                table: "PurchaseOrder",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "zpqd",
                table: "Person",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Account",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ModelSplitCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    cCusCode = table.Column<string>(maxLength: 20, nullable: true),
                    cCusName = table.Column<string>(maxLength: 98, nullable: true),
                    cInvCode = table.Column<string>(maxLength: 120, nullable: true),
                    cInvName = table.Column<string>(maxLength: 510, nullable: true),
                    cInvStd = table.Column<string>(maxLength: 50, nullable: true),
                    sProject = table.Column<string>(maxLength: 50, nullable: true),
                    sGroup = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ModelSplitCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    cCusCode = table.Column<string>(maxLength: 20, nullable: true),
                    cCusName = table.Column<string>(maxLength: 98, nullable: true),
                    cInvCode = table.Column<string>(maxLength: 120, nullable: true),
                    cInvName = table.Column<string>(maxLength: 510, nullable: true),
                    cInvStd = table.Column<string>(maxLength: 50, nullable: true),
                    cCusInvCode = table.Column<string>(maxLength: 50, nullable: true),
                    fButgetPrice = table.Column<float>(maxLength: 50, nullable: false),
                    fTempPrice = table.Column<float>(maxLength: 50, nullable: false),
                    fDefinePrice = table.Column<float>(maxLength: 50, nullable: false),
                    IsAgreement = table.Column<bool>(nullable: false),
                    IsInward = table.Column<bool>(nullable: false),
                    ModelSplitCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSale", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelSplitCost");

            migrationBuilder.DropTable(
                name: "ProductSale");

            migrationBuilder.DropColumn(
                name: "cCode",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "cPTCode",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Account");

            migrationBuilder.AlterColumn<string>(
                name: "zpqd",
                table: "Person",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}

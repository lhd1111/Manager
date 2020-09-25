using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 产品销售 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ProductSale");
        }
    }
}

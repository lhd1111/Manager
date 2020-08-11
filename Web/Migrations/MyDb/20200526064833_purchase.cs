using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AccountDate",
                table: "Supplier",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    RdRecordId = table.Column<string>(maxLength: 30, nullable: true),
                    cOrderCode = table.Column<string>(maxLength: 30, nullable: true),
                    cARVcode = table.Column<string>(maxLength: 30, nullable: true),
                    PBVId = table.Column<string>(maxLength: 30, nullable: true),
                    cPBVCode = table.Column<string>(maxLength: 30, nullable: true),
                    ReceiveDate = table.Column<DateTime>(nullable: false),
                    U8Code = table.Column<string>(maxLength: 60, nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Tax = table.Column<int>(nullable: false),
                    TaxPrice = table.Column<float>(nullable: false),
                    iSum = table.Column<float>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "AccountDate",
                table: "Supplier");
        }
    }
}

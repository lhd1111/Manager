using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class salesReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirm",
                table: "MaterialSplitCost",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SalesReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    CustomerName = table.Column<string>(maxLength: 60, nullable: true),
                    U8Code = table.Column<string>(maxLength: 60, nullable: true),
                    iQuantity = table.Column<int>(nullable: false),
                    iSum = table.Column<float>(nullable: false),
                    iPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReport", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesReport");

            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "MaterialSplitCost");
        }
    }
}

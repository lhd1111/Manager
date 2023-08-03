using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 包装属性 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricePacking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    ContainerSize = table.Column<string>(maxLength: 50, nullable: true),
                    ContainerCost = table.Column<string>(maxLength: 50, nullable: true),
                    Container = table.Column<string>(maxLength: 50, nullable: true),
                    PackingCost = table.Column<string>(maxLength: 50, nullable: true),
                    PackingId = table.Column<int>(maxLength: 20, nullable: false),
                    BomId = table.Column<int>(nullable: false),
                    PriceCollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricePacking", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricePacking");
        }
    }
}

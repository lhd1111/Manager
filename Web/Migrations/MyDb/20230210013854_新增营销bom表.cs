using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增营销bom表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketBom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Scope = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Inventory = table.Column<string>(nullable: true),
                    FsCode = table.Column<string>(maxLength: 50, nullable: true),
                    U8Code = table.Column<string>(maxLength: 60, nullable: true),
                    Unit = table.Column<string>(maxLength: 5, nullable: true),
                    U8Dept = table.Column<string>(maxLength: 20, nullable: true),
                    iOrder = table.Column<int>(nullable: false),
                    CustomCode = table.Column<string>(maxLength: 100, nullable: true),
                    Number = table.Column<float>(nullable: false),
                    U8Number = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    GrossWeight = table.Column<string>(maxLength: 100, nullable: true),
                    Color = table.Column<string>(maxLength: 100, nullable: true),
                    Paint = table.Column<string>(maxLength: 100, nullable: true),
                    Surface = table.Column<string>(maxLength: 100, nullable: true),
                    Specs = table.Column<string>(maxLength: 100, nullable: true),
                    Tooling = table.Column<string>(maxLength: 100, nullable: true),
                    Material = table.Column<string>(maxLength: 100, nullable: true),
                    ModleCavity = table.Column<string>(maxLength: 100, nullable: true),
                    MakeMothod = table.Column<string>(maxLength: 1, nullable: true),
                    Characteristic = table.Column<string>(maxLength: 50, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    IsVirtual = table.Column<bool>(nullable: false),
                    PriceCollectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketBom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketBom_MarketBom_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MarketBom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketBom_ParentId",
                table: "MarketBom",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketBom");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 工艺巡检 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineNum",
                table: "ModelList");

            migrationBuilder.CreateTable(
                name: "CheckDetail",
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
                    Value1 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value2 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value3 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value4 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value5 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value6 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Value7 = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    iOrder = table.Column<int>(nullable: false),
                    ModelDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckDetail_CheckDetail_ParentId",
                        column: x => x.ParentId,
                        principalTable: "CheckDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModelDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Version = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    MachineNum = table.Column<int>(nullable: false),
                    ModelDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelDetail", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetail_ParentId",
                table: "CheckDetail",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckDetail");

            migrationBuilder.DropTable(
                name: "ModelDetail");

            migrationBuilder.AddColumn<int>(
                name: "MachineNum",
                table: "ModelList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

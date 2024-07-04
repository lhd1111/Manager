using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class initKpi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "TwoEnum",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "KpiMain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    EnumId = table.Column<int>(nullable: false),
                    EnumStr = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    iYear = table.Column<int>(nullable: false),
                    iTotal = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_01 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_02 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_03 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    Q_01 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_04 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_05 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_06 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    Q_02 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_07 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_08 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_09 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    Q_03 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_10 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_11 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    M_12 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    Q_04 = table.Column<decimal>(type: "decimal(15, 4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KpiMain", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KpiMain");

            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "TwoEnum");
        }
    }
}

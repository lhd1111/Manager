using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增分子分母记录 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FmM_01",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_02",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_03",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_04",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_05",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_06",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_07",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_08",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_09",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_10",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_11",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmM_12",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmQ_01",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmQ_02",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmQ_03",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FmQ_04",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_01",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_02",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_03",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_04",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_05",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_06",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_07",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_08",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_09",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_10",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_11",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzM_12",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzQ_01",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzQ_02",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzQ_03",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FzQ_04",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "iTotalFm",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 1m);

            migrationBuilder.AddColumn<decimal>(
                name: "iTotalFz",
                table: "KpiMain",
                type: "decimal(15, 4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FmM_01",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_02",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_03",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_04",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_05",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_06",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_07",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_08",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_09",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_10",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_11",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmM_12",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmQ_01",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmQ_02",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmQ_03",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FmQ_04",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_01",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_02",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_03",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_04",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_05",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_06",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_07",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_08",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_09",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_10",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_11",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzM_12",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzQ_01",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzQ_02",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzQ_03",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "FzQ_04",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "iTotalFm",
                table: "KpiMain");

            migrationBuilder.DropColumn(
                name: "iTotalFz",
                table: "KpiMain");
        }
    }
}

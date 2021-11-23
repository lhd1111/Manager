using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 统计修改 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TableId",
                table: "BusSummary",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "BusSummary",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableId",
                table: "BusSummary");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "BusSummary");
        }
    }
}

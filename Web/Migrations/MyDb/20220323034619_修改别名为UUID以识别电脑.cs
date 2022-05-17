using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改别名为UUID以识别电脑 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "FixedAsset");

            migrationBuilder.AddColumn<string>(
                name: "UUID",
                table: "FixedAsset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UUID",
                table: "FixedAsset");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "FixedAsset",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增拆码信息 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "ThreePointDetail",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num",
                table: "ThreePointDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ThreePointDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batch",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "Num",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ThreePointDetail");
        }
    }
}

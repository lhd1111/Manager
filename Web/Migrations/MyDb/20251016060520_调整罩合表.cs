using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 调整罩合表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "ThreePointDetail");

            migrationBuilder.AddColumn<string>(
                name: "Mo_SoId",
                table: "ThreePointDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoId",
                table: "ThreePointDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mScanStr",
                table: "ThreePointDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mo_SoId",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "SoId",
                table: "ThreePointDetail");

            migrationBuilder.DropColumn(
                name: "mScanStr",
                table: "ThreePointDetail");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "ThreePointDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Source",
                table: "ThreePointDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

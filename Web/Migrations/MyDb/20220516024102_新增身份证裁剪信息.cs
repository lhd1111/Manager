using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增身份证裁剪信息 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardBack",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardFront",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardBack",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CardFront",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Person");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 访客新增卡数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cardf",
                table: "Reception",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cards",
                table: "Reception",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cardf",
                table: "Reception");

            migrationBuilder.DropColumn(
                name: "cards",
                table: "Reception");
        }
    }
}

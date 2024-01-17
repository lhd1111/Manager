using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 点餐记录口味及份数 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fl",
                table: "DishRecord",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "kw",
                table: "DishRecord",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fl",
                table: "DishRecord");

            migrationBuilder.DropColumn(
                name: "kw",
                table: "DishRecord");
        }
    }
}

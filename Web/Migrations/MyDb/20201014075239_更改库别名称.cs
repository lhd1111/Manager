using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 更改库别名称 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataBase",
                table: "PU_AppVouch");

            migrationBuilder.AddColumn<string>(
                name: "cDataBase",
                table: "PU_AppVouch",
                maxLength: 3,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cDataBase",
                table: "PU_AppVouch");

            migrationBuilder.AddColumn<string>(
                name: "DataBase",
                table: "PU_AppVouch",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);
        }
    }
}

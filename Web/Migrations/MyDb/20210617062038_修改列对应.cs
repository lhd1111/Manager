using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改列对应 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "U8Column",
                table: "ColToCol");

            migrationBuilder.AddColumn<string>(
                name: "rsU8DataBase",
                table: "ColToCol",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rsU8DataBase",
                table: "ColToCol");

            migrationBuilder.AddColumn<string>(
                name: "U8Column",
                table: "ColToCol",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

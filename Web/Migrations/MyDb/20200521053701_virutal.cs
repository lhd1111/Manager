using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class virutal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialDataBase",
                table: "SinglePrice",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVirtual",
                table: "Bom",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialDataBase",
                table: "SinglePrice");

            migrationBuilder.DropColumn(
                name: "IsVirtual",
                table: "Bom");
        }
    }
}

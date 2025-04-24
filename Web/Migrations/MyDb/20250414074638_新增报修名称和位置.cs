using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增报修名称和位置 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ssmc",
                table: "Repair",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sswz",
                table: "Repair",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierPartCode",
                table: "Bom",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ssmc",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "sswz",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "SupplierPartCode",
                table: "Bom");
        }
    }
}

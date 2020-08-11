using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class supplierU8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "U8DataBase",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "U8VendorClass",
                table: "Supplier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "U8DataBase",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "U8VendorClass",
                table: "Supplier");
        }
    }
}

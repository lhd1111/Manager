using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "U8Vendor",
                table: "SinglePrice");

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Supplier",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Supplier");

            migrationBuilder.AddColumn<string>(
                name: "U8Vendor",
                table: "SinglePrice",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

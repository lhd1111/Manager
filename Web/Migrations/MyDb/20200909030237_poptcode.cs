using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class poptcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cCode",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cPTCode",
                table: "PurchaseOrder",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cCode",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "cPTCode",
                table: "PurchaseOrder");
        }
    }
}

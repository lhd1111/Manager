using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class poQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iQuntity",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<float>(
                name: "iQuantity",
                table: "PurchaseOrder",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iQuantity",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<float>(
                name: "iQuntity",
                table: "PurchaseOrder",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

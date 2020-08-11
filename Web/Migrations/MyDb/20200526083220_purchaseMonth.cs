using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class purchaseMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountMonth",
                table: "PurchaseOrder",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "iTaxSum",
                table: "PurchaseOrder",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountMonth",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "iTaxSum",
                table: "PurchaseOrder");
        }
    }
}

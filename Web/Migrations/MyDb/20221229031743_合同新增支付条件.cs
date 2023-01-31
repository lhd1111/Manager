using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 合同新增支付条件 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "PurchaseDetail");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "PurchaseDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayNote",
                table: "PurchaseDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "PurchaseDetail");

            migrationBuilder.DropColumn(
                name: "PayNote",
                table: "PurchaseDetail");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "PurchaseDetail",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

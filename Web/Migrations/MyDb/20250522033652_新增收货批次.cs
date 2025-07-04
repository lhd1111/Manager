using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增收货批次 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "VendorScan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mBatch",
                table: "VendorScan",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batch",
                table: "VendorScan");

            migrationBuilder.DropColumn(
                name: "mBatch",
                table: "VendorScan");
        }
    }
}

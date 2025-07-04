using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 供应商混合存储 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cInvCodeAll",
                table: "POScan");

            migrationBuilder.DropColumn(
                name: "cInvName",
                table: "POScan");

            migrationBuilder.DropColumn(
                name: "cInvNameAll",
                table: "POScan");

            migrationBuilder.AddColumn<string>(
                name: "cInvCodeAll",
                table: "VendorScan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvName",
                table: "VendorScan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvNameAll",
                table: "VendorScan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cInvCodeAll",
                table: "VendorScan");

            migrationBuilder.DropColumn(
                name: "cInvName",
                table: "VendorScan");

            migrationBuilder.DropColumn(
                name: "cInvNameAll",
                table: "VendorScan");

            migrationBuilder.AddColumn<string>(
                name: "cInvCodeAll",
                table: "POScan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvName",
                table: "POScan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvNameAll",
                table: "POScan",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

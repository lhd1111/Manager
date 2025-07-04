using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增混合存储 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cInvCodeAll",
                table: "POScan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvName",
                table: "POScan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvNameAll",
                table: "POScan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增requestid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "docId",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "requestId",
                table: "Invoice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "docId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "requestId",
                table: "Invoice");
        }
    }
}

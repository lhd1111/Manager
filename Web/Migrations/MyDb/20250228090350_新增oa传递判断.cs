using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增oa传递判断 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceDate",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCreate",
                table: "Invoice",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceDate",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "IsCreate",
                table: "Invoice");
        }
    }
}

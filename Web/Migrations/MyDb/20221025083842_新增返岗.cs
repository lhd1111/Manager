using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增返岗 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isQsFg",
                table: "Person",
                maxLength: 20,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isQsSpan",
                table: "Person",
                maxLength: 20,
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isQsFg",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "isQsSpan",
                table: "Person");
        }
    }
}

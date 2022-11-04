using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增亲属 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isQsFg",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "isQsSpan",
                table: "Person");

            migrationBuilder.AddColumn<bool>(
                name: "isFg",
                table: "Person",
                maxLength: 20,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isQs",
                table: "Person",
                maxLength: 20,
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFg",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "isQs",
                table: "Person");

            migrationBuilder.AddColumn<bool>(
                name: "isQsFg",
                table: "Person",
                type: "bit",
                maxLength: 20,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isQsSpan",
                table: "Person",
                type: "bit",
                maxLength: 20,
                nullable: false,
                defaultValue: false);
        }
    }
}

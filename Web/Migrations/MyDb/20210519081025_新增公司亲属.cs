using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增公司亲属 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Relatives",
                table: "Person",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cRelation",
                table: "Person",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Relatives",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "cRelation",
                table: "Person");
        }
    }
}

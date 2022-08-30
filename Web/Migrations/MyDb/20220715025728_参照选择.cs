using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 参照选择 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRef",
                table: "ModelDetail",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRef",
                table: "ModelDetail");
        }
    }
}

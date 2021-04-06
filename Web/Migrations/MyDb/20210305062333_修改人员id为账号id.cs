using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改人员id为账号id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "SystemCheckResult");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "SystemCheckResult",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "SystemCheckResult");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "SystemCheckResult",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

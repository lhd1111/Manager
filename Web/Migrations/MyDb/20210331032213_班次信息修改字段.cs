using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 班次信息修改字段 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCd",
                table: "Frequency");

            migrationBuilder.AddColumn<string>(
                name: "IsCdZt",
                table: "Frequency",
                maxLength: 2,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCdZt",
                table: "Frequency");

            migrationBuilder.AddColumn<string>(
                name: "IsCd",
                table: "Frequency",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);
        }
    }
}

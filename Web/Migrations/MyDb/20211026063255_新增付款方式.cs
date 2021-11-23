using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增付款方式 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Method",
                table: "AccommodationContract",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Money",
                table: "AccommodationContract",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Method",
                table: "AccommodationContract");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "AccommodationContract");
        }
    }
}

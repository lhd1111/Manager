using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 运费分摊新增供应商和存货 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cCusCode",
                table: "FreightSplit",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cInvCode",
                table: "FreightSplit",
                maxLength: 120,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cCusCode",
                table: "FreightSplit");

            migrationBuilder.DropColumn(
                name: "cInvCode",
                table: "FreightSplit");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具分摊供应商编码 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cCusCode",
                table: "ModelSplitCost",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cCusName",
                table: "ModelSplitCost",
                maxLength: 98,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cCusCode",
                table: "ModelSplitCost");

            migrationBuilder.DropColumn(
                name: "cCusName",
                table: "ModelSplitCost");
        }
    }
}

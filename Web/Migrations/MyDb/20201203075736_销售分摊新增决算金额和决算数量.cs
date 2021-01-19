using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 销售分摊新增决算金额和决算数量 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "fFinalCost",
                table: "ModelSplitCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "iFinalNum",
                table: "ModelSplitCost",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fFinalCost",
                table: "ModelSplitCost");

            migrationBuilder.DropColumn(
                name: "iFinalNum",
                table: "ModelSplitCost");
        }
    }
}

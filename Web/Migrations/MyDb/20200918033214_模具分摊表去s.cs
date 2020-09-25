using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 模具分摊表去s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelSplitCosts",
                table: "ModelSplitCosts");

            migrationBuilder.RenameTable(
                name: "ModelSplitCosts",
                newName: "ModelSplitCost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelSplitCost",
                table: "ModelSplitCost",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ModelSplitCost",
                table: "ModelSplitCost");

            migrationBuilder.RenameTable(
                name: "ModelSplitCost",
                newName: "ModelSplitCosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModelSplitCosts",
                table: "ModelSplitCosts",
                column: "Id");
        }
    }
}

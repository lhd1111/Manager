using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修改模具关联 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "ModelList");

            migrationBuilder.AddColumn<int>(
                name: "MachineNum",
                table: "ModelList",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineNum",
                table: "ModelList");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "ModelList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

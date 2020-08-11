using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class deptall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "oDepartmentId",
                table: "Department",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rDepartmentID",
                table: "Department",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uDepartmnetID",
                table: "Department",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "oDepartmentId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "rDepartmentID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "uDepartmnetID",
                table: "Department");
        }
    }
}

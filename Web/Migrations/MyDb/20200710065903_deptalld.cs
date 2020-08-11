using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class deptalld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uDepartmnetID",
                table: "Department",
                newName: "uDepartmnetId");

            migrationBuilder.RenameColumn(
                name: "rDepartmentID",
                table: "Department",
                newName: "rDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uDepartmnetId",
                table: "Department",
                newName: "uDepartmnetID");

            migrationBuilder.RenameColumn(
                name: "rDepartmentId",
                table: "Department",
                newName: "rDepartmentID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 部门新增全称 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kDepartmentId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "rDepartmentId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "uDepartmnetId",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Department");

            migrationBuilder.AddColumn<int>(
                name: "kDepartmentId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "rDepartmentId",
                table: "Department",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uDepartmnetId",
                table: "Department",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}

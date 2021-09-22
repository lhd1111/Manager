using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 撤除f_98由jrjbg代替 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "F_98",
                table: "SalaryAttendance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "F_98",
                table: "SalaryAttendance",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}

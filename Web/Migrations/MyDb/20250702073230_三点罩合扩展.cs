using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 三点罩合扩展 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvCode",
                table: "ThreePoint",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "ThreePoint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCode",
                table: "ThreePoint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvName",
                table: "ThreePoint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvStd",
                table: "ThreePoint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "ThreePoint");

            migrationBuilder.DropColumn(
                name: "CustomerCode",
                table: "ThreePoint");

            migrationBuilder.DropColumn(
                name: "InvName",
                table: "ThreePoint");

            migrationBuilder.DropColumn(
                name: "InvStd",
                table: "ThreePoint");

            migrationBuilder.AlterColumn<string>(
                name: "InvCode",
                table: "ThreePoint",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}

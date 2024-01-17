using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 菜单名称错误 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Catering",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Catering");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Catering",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Catering",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catering",
                table: "Catering",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Catering",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Catering");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Catering",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Key",
                table: "Catering",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catering",
                table: "Catering",
                column: "Key");
        }
    }
}

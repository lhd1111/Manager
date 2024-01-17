using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 每日餐点调整 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Week1",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week2",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week3",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week4",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week5",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week6",
                table: "Catering",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week7",
                table: "Catering",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsCg",
                table: "CanteeMenu",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "ForceMinute",
                table: "CanteeMenu",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Week1",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week2",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week3",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week4",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week5",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week6",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "Week7",
                table: "Catering");

            migrationBuilder.DropColumn(
                name: "ForceMinute",
                table: "CanteeMenu");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCg",
                table: "CanteeMenu",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);
        }
    }
}

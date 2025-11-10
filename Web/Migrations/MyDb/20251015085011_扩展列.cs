using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 扩展列 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierBatch",
                table: "BarcodePrt");

            migrationBuilder.AddColumn<string>(
                name: "ItemMaster",
                table: "ThreePoint",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Org",
                table: "ThreePoint",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Org",
                table: "Bao_gy",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemMaster",
                table: "ThreePoint");

            migrationBuilder.DropColumn(
                name: "Org",
                table: "ThreePoint");

            migrationBuilder.AddColumn<string>(
                name: "SupplierBatch",
                table: "BarcodePrt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Org",
                table: "Bao_gy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}

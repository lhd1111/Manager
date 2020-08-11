using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class pofull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RdRecordId",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PBVId",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RdsId",
                table: "PurchaseOrder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iPOsID",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RdsId",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "iPOsID",
                table: "PurchaseOrder");

            migrationBuilder.AlterColumn<string>(
                name: "RdRecordId",
                table: "PurchaseOrder",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PBVId",
                table: "PurchaseOrder",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}

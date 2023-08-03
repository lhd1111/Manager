using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 普表转树表 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OaApplyId",
                table: "PriceCollection");

            migrationBuilder.AddColumn<bool>(
                name: "IsLeaf",
                table: "PriceCollection",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "PriceCollection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PriceCollection",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "PriceCollection",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Scope",
                table: "PriceCollection",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceCollection_ParentId",
                table: "PriceCollection",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceCollection_PriceCollection_ParentId",
                table: "PriceCollection",
                column: "ParentId",
                principalTable: "PriceCollection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceCollection_PriceCollection_ParentId",
                table: "PriceCollection");

            migrationBuilder.DropIndex(
                name: "IX_PriceCollection_ParentId",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "IsLeaf",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "PriceCollection");

            migrationBuilder.DropColumn(
                name: "Scope",
                table: "PriceCollection");

            migrationBuilder.AddColumn<int>(
                name: "OaApplyId",
                table: "PriceCollection",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

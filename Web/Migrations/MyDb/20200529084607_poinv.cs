using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class poinv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "PurchaseOrder",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "iDate",
                table: "PurchaseOrder",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "iDate",
                table: "PurchaseOrder");
        }
    }
}

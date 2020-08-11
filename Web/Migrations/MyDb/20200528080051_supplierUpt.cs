using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class supplierUpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "U8VendorClass",
                table: "Supplier");

            migrationBuilder.AddColumn<float>(
                name: "iQuntity",
                table: "PurchaseOrder",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iQuntity",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Supplier",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "U8VendorClass",
                table: "Supplier",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);
        }
    }
}

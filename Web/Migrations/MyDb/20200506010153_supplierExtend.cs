using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class supplierExtend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Supplier",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Supplier",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostMail",
                table: "Supplier",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierPhone",
                table: "Supplier",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidDate",
                table: "Supplier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "PostMail",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "SupplierPhone",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "ValidDate",
                table: "Supplier");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增合同上传 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "UpLoadFile",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "UpLoadFile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UpLoadFile",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignDate",
                table: "AccommodationContract",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "AccommodationContract",
                maxLength: 4,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "UpLoadFile");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "UpLoadFile");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UpLoadFile");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AccommodationContract");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignDate",
                table: "AccommodationContract",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}

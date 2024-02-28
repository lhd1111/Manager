using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增家庭关系 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OneIncome",
                table: "PriceSelling",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4, 2)");

            migrationBuilder.AddColumn<string>(
                name: "CommutingDuration",
                table: "Person",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommutingMethod",
                table: "Person",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeChatQQ",
                table: "Person",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FamilyExp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 10, nullable: true),
                    Title = table.Column<string>(maxLength: 10, nullable: true),
                    CompanyStr = table.Column<string>(maxLength: 10, nullable: true),
                    Tel = table.Column<string>(maxLength: 10, nullable: true),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyExp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyExp_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FamilyExp_PersonId",
                table: "FamilyExp",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamilyExp");

            migrationBuilder.DropColumn(
                name: "CommutingDuration",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CommutingMethod",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "WeChatQQ",
                table: "Person");

            migrationBuilder.AlterColumn<decimal>(
                name: "OneIncome",
                table: "PriceSelling",
                type: "decimal(4, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");
        }
    }
}

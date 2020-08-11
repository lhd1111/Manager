using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class ms1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MouldState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    MouldNo = table.Column<string>(maxLength: 20, nullable: true),
                    ProjectName = table.Column<string>(maxLength: 20, nullable: true),
                    MouldName = table.Column<string>(maxLength: 20, nullable: true),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    T0Mould = table.Column<DateTime>(maxLength: 20, nullable: true),
                    MaterialBack = table.Column<DateTime>(nullable: true),
                    MouldBack = table.Column<DateTime>(nullable: true),
                    MouldProgress = table.Column<string>(maxLength: 20, nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MouldState", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MouldState");
        }
    }
}

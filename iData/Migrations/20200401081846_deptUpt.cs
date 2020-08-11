using Microsoft.EntityFrameworkCore.Migrations;

namespace iData.Migrations
{
    public partial class deptUpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rd_Pools_rd_Pools_ParentId",
                table: "rd_Pools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rd_Pools",
                table: "rd_Pools");

            migrationBuilder.RenameTable(
                name: "rd_Pools",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_rd_Pools_ParentId",
                table: "Department",
                newName: "IX_Department_ParentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Department_ParentId",
                table: "Department",
                column: "ParentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Department_ParentId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "rd_Pools");

            migrationBuilder.RenameIndex(
                name: "IX_Department_ParentId",
                table: "rd_Pools",
                newName: "IX_rd_Pools_ParentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "rd_Pools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_rd_Pools",
                table: "rd_Pools",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_rd_Pools_rd_Pools_ParentId",
                table: "rd_Pools",
                column: "ParentId",
                principalTable: "rd_Pools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

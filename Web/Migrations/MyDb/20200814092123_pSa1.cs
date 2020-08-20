using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class pSa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Person_PersonId",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "SalaryExp");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_PersonId",
                table: "SalaryExp",
                newName: "IX_SalaryExp_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaryExp",
                table: "SalaryExp",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryExp_Person_PersonId",
                table: "SalaryExp",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryExp_Person_PersonId",
                table: "SalaryExp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaryExp",
                table: "SalaryExp");

            migrationBuilder.RenameTable(
                name: "SalaryExp",
                newName: "Salaries");

            migrationBuilder.RenameIndex(
                name: "IX_SalaryExp_PersonId",
                table: "Salaries",
                newName: "IX_Salaries_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Person_PersonId",
                table: "Salaries",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 修正领导意见与账号的关联 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadIdea_Account_AccountId",
                table: "LeadIdea");

            migrationBuilder.DropIndex(
                name: "IX_LeadIdea_AccountId",
                table: "LeadIdea");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "LeadIdea",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "LeadIdea",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_LeadIdea_AccountId",
                table: "LeadIdea",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadIdea_Account_AccountId",
                table: "LeadIdea",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

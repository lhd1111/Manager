using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class person0708 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_LocationId",
                table: "Person",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_LocationId",
                table: "Person",
                column: "LocationId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_LocationId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_LocationId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Person");
        }
    }
}

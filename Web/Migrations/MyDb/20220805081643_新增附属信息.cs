using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class 新增附属信息 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "ProjectProblem",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ProjectProblem",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "ProjectProblem",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubmitGh",
                table: "ProjectProblem",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Submitter",
                table: "ProjectProblem",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "requestid",
                table: "ProjectProblem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarType",
                table: "ProjectProblem");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ProjectProblem");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "ProjectProblem");

            migrationBuilder.DropColumn(
                name: "SubmitGh",
                table: "ProjectProblem");

            migrationBuilder.DropColumn(
                name: "Submitter",
                table: "ProjectProblem");

            migrationBuilder.DropColumn(
                name: "requestid",
                table: "ProjectProblem");
        }
    }
}

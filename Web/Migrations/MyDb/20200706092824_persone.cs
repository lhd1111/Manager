using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class persone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationExp_TwoEnum_EducationId",
                table: "EducationExp");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_TwoEnum_EducationId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_TwoEnum_MaritalStateId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_TwoEnum_PostId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_TwoEnum_ProficiencyId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_EducationId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_MaritalStateId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_ProficiencyId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_EducationExp_EducationId",
                table: "EducationExp");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "Post",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MaritalStateId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "EducationExp");

            migrationBuilder.AddColumn<string>(
                name: "Certifier",
                table: "WorkExp",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertifierTel",
                table: "WorkExp",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentStr",
                table: "WorkExp",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostStr",
                table: "WorkExp",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Person",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "CEmail",
                table: "Person",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EName",
                table: "Person",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Person",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalState",
                table: "Person",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proficiency",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "EducationExp",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    PostName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_DepartmentId",
                table: "Post",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Post_PostId",
                table: "Person",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Post_PostId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropColumn(
                name: "Certifier",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "CertifierTel",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "DepartmentStr",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "PostStr",
                table: "WorkExp");

            migrationBuilder.DropColumn(
                name: "CEmail",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MaritalState",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Proficiency",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "EducationExp");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "WorkExp",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "WorkExp",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "WorkExp",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Sex",
                table: "Person",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStateId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProficiencyId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "EducationExp",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_EducationId",
                table: "Person",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MaritalStateId",
                table: "Person",
                column: "MaritalStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ProficiencyId",
                table: "Person",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationExp_EducationId",
                table: "EducationExp",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationExp_TwoEnum_EducationId",
                table: "EducationExp",
                column: "EducationId",
                principalTable: "TwoEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_TwoEnum_EducationId",
                table: "Person",
                column: "EducationId",
                principalTable: "TwoEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_TwoEnum_MaritalStateId",
                table: "Person",
                column: "MaritalStateId",
                principalTable: "TwoEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_TwoEnum_PostId",
                table: "Person",
                column: "PostId",
                principalTable: "TwoEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_TwoEnum_ProficiencyId",
                table: "Person",
                column: "ProficiencyId",
                principalTable: "TwoEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

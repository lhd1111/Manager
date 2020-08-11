using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations.MyDb
{
    public partial class person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TwoEnum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Scope = table.Column<string>(maxLength: 100, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TwoEnum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TwoEnum_TwoEnum_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    DepartmentStr = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    PostStr = table.Column<string>(maxLength: 20, nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<bool>(nullable: false),
                    MaritalStateId = table.Column<int>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    RegisterLocation = table.Column<string>(maxLength: 50, nullable: true),
                    LiveLocation = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Tel = table.Column<string>(maxLength: 20, nullable: true),
                    Contact = table.Column<string>(maxLength: 20, nullable: true),
                    Relation = table.Column<string>(maxLength: 20, nullable: true),
                    ContactTel = table.Column<string>(maxLength: 20, nullable: true),
                    EducationId = table.Column<int>(nullable: true),
                    Profession = table.Column<string>(maxLength: 20, nullable: true),
                    School = table.Column<string>(maxLength: 50, nullable: true),
                    Language = table.Column<string>(maxLength: 20, nullable: true),
                    ProficiencyId = table.Column<int>(nullable: true),
                    Speciality = table.Column<string>(maxLength: 50, nullable: true),
                    PostDate = table.Column<DateTime>(nullable: true),
                    TestMonth = table.Column<int>(nullable: false),
                    TestSalary = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    RsPass = table.Column<string>(nullable: true),
                    JlPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_TwoEnum_EducationId",
                        column: x => x.EducationId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_TwoEnum_MaritalStateId",
                        column: x => x.MaritalStateId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_TwoEnum_PostId",
                        column: x => x.PostId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_TwoEnum_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationExp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    School = table.Column<string>(maxLength: 50, nullable: true),
                    EducationId = table.Column<int>(nullable: true),
                    Profession = table.Column<string>(maxLength: 20, nullable: true),
                    IsFull = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationExp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationExp_TwoEnum_EducationId",
                        column: x => x.EducationId,
                        principalTable: "TwoEnum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationExp_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainExp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsInner = table.Column<bool>(nullable: false),
                    Teacher = table.Column<string>(maxLength: 20, nullable: true),
                    Certificate = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainExp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainExp_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkExp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 20, nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 20, nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Company = table.Column<string>(maxLength: 50, nullable: true),
                    Department = table.Column<string>(maxLength: 20, nullable: true),
                    Post = table.Column<string>(maxLength: 20, nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExp_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationExp_EducationId",
                table: "EducationExp",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationExp_PersonId",
                table: "EducationExp",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentId",
                table: "Person",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EducationId",
                table: "Person",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MaritalStateId",
                table: "Person",
                column: "MaritalStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PostId",
                table: "Person",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ProficiencyId",
                table: "Person",
                column: "ProficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainExp_PersonId",
                table: "TrainExp",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TwoEnum_ParentId",
                table: "TwoEnum",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExp_PersonId",
                table: "WorkExp",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationExp");

            migrationBuilder.DropTable(
                name: "TrainExp");

            migrationBuilder.DropTable(
                name: "WorkExp");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "TwoEnum");
        }
    }
}

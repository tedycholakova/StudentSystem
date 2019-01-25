using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class AddStudentSubjectMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Marks_MarkId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Marks_MarkId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_MarkId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_MarkId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Marks",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_SubjectId",
                table: "Marks",
                newName: "IX_Marks_StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teacher",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "StudentSubjectMark",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    MarkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjectMark", x => new { x.StudentId, x.SubjectId, x.MarkId });
                    table.UniqueConstraint("AK_StudentSubjectMark_MarkId_StudentId_SubjectId", x => new { x.MarkId, x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubjectMark_Marks_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Marks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMark_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMark_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CourseId",
                table: "Marks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMark_SubjectId",
                table: "StudentSubjectMark",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Courses_CourseId",
                table: "Marks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Courses_CourseId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Students_StudentId",
                table: "Marks");

            migrationBuilder.DropTable(
                name: "StudentSubjectMark");

            migrationBuilder.DropIndex(
                name: "IX_Marks_CourseId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Marks");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Marks",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StudentId",
                table: "Marks",
                newName: "IX_Marks_SubjectId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teacher",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Students",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_MarkId",
                table: "Students",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MarkId",
                table: "Courses",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Marks_MarkId",
                table: "Courses",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Subjects_SubjectId",
                table: "Marks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Marks_MarkId",
                table: "Students",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

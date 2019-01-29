using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class OverrideConvensionsForModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMark_Marks_MarkId",
                table: "StudentSubjectMark");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMark_Students_StudentId",
                table: "StudentSubjectMark");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMark_Subjects_SubjectId",
                table: "StudentSubjectMark");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_StudentSubjectMark_MarkId_StudentId_SubjectId",
                table: "StudentSubjectMark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjectMark",
                table: "StudentSubjectMark");

            migrationBuilder.RenameTable(
                name: "StudentSubjectMark",
                newName: "StudentSubjectMarks");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubjectMark_SubjectId",
                table: "StudentSubjectMarks",
                newName: "IX_StudentSubjectMarks_SubjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjectMarks",
                table: "StudentSubjectMarks",
                columns: new[] { "StudentId", "SubjectId", "MarkId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMarks_MarkId",
                table: "StudentSubjectMarks",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMarks_Marks_MarkId",
                table: "StudentSubjectMarks",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMarks_Students_StudentId",
                table: "StudentSubjectMarks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMarks_Subjects_SubjectId",
                table: "StudentSubjectMarks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMarks_Marks_MarkId",
                table: "StudentSubjectMarks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMarks_Students_StudentId",
                table: "StudentSubjectMarks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMarks_Subjects_SubjectId",
                table: "StudentSubjectMarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjectMarks",
                table: "StudentSubjectMarks");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjectMarks_MarkId",
                table: "StudentSubjectMarks");

            migrationBuilder.RenameTable(
                name: "StudentSubjectMarks",
                newName: "StudentSubjectMark");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubjectMarks_SubjectId",
                table: "StudentSubjectMark",
                newName: "IX_StudentSubjectMark_SubjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Marks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_StudentSubjectMark_MarkId_StudentId_SubjectId",
                table: "StudentSubjectMark",
                columns: new[] { "MarkId", "StudentId", "SubjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjectMark",
                table: "StudentSubjectMark",
                columns: new[] { "StudentId", "SubjectId", "MarkId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMark_Marks_MarkId",
                table: "StudentSubjectMark",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMark_Students_StudentId",
                table: "StudentSubjectMark",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMark_Subjects_SubjectId",
                table: "StudentSubjectMark",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

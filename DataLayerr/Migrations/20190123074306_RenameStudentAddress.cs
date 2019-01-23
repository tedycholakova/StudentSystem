using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class RenameStudentAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentAddresses_AddressId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses");

            migrationBuilder.RenameTable(
                name: "StudentAddresses",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Addresses_AddressId",
                table: "Students",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Addresses_AddressId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "StudentAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentAddresses_AddressId",
                table: "Students",
                column: "AddressId",
                principalTable: "StudentAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

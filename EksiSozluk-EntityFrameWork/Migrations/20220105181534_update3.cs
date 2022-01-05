using Microsoft.EntityFrameworkCore.Migrations;

namespace EksiSozluk_EntityFrameWork.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_genderID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_genderID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "genderID1",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "genderID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_genderID",
                table: "Users",
                column: "genderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_genderID",
                table: "Users",
                column: "genderID",
                principalTable: "Genders",
                principalColumn: "genderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_genderID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_genderID",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "genderID",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "genderID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_genderID1",
                table: "Users",
                column: "genderID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_genderID1",
                table: "Users",
                column: "genderID1",
                principalTable: "Genders",
                principalColumn: "genderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

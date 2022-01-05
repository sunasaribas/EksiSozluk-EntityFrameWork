using Microsoft.EntityFrameworkCore.Migrations;

namespace EksiSozluk_EntityFrameWork.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Users",
                newName: "genderID");

            migrationBuilder.AddColumn<int>(
                name: "genderID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    genderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.genderID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_genderID1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Users_genderID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "genderID1",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "genderID",
                table: "Users",
                newName: "gender");
        }
    }
}

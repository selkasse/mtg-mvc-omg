using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_MVC_OMG.Migrations
{
    public partial class addReferencesBackToPlayerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreferredColorId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferredFormatId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PreferredColorId",
                table: "Player",
                column: "PreferredColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PreferredFormatId",
                table: "Player",
                column: "PreferredFormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Color_PreferredColorId",
                table: "Player",
                column: "PreferredColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Format_PreferredFormatId",
                table: "Player",
                column: "PreferredFormatId",
                principalTable: "Format",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Color_PreferredColorId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Format_PreferredFormatId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PreferredColorId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PreferredFormatId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PreferredColorId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PreferredFormatId",
                table: "Player");
        }
    }
}

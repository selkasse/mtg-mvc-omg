using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_MVC_OMG.Migrations
{
    public partial class makeModelsPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Color_PreferredColorId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Format_PreferredFormatId",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Format",
                table: "Format");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "Format",
                newName: "Formats");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.RenameIndex(
                name: "IX_Player_PreferredFormatId",
                table: "Players",
                newName: "IX_Players_PreferredFormatId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_PreferredColorId",
                table: "Players",
                newName: "IX_Players_PreferredColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formats",
                table: "Formats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Colors_PreferredColorId",
                table: "Players",
                column: "PreferredColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Formats_PreferredFormatId",
                table: "Players",
                column: "PreferredFormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Colors_PreferredColorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Formats_PreferredFormatId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formats",
                table: "Formats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Player");

            migrationBuilder.RenameTable(
                name: "Formats",
                newName: "Format");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PreferredFormatId",
                table: "Player",
                newName: "IX_Player_PreferredFormatId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PreferredColorId",
                table: "Player",
                newName: "IX_Player_PreferredColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Format",
                table: "Format",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "Id");

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
    }
}

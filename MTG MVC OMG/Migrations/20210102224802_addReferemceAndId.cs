using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_MVC_OMG.Migrations
{
    public partial class addReferemceAndId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Colors_ColorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Formats_FormatId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_ColorId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_FormatId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FormatId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "PreferredFormat",
                table: "Players",
                newName: "PreferredFormatId");

            migrationBuilder.RenameColumn(
                name: "PreferredColor",
                table: "Players",
                newName: "PreferredColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PreferredColorId",
                table: "Players",
                column: "PreferredColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PreferredFormatId",
                table: "Players",
                column: "PreferredFormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Colors_PreferredColorId",
                table: "Players",
                column: "PreferredColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Formats_PreferredFormatId",
                table: "Players",
                column: "PreferredFormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Colors_PreferredColorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Formats_PreferredFormatId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PreferredColorId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PreferredFormatId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "PreferredFormatId",
                table: "Players",
                newName: "PreferredFormat");

            migrationBuilder.RenameColumn(
                name: "PreferredColorId",
                table: "Players",
                newName: "PreferredColor");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormatId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_ColorId",
                table: "Players",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_FormatId",
                table: "Players",
                column: "FormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Colors_ColorId",
                table: "Players",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Formats_FormatId",
                table: "Players",
                column: "FormatId",
                principalTable: "Formats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

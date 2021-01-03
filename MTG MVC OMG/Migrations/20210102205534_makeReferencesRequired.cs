using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_MVC_OMG.Migrations
{
    public partial class makeReferencesRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Colors_PreferredColorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Formats_PreferredFormatId",
                table: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "PreferredFormatId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PreferredColorId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "PreferredFormatId",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PreferredColorId",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}

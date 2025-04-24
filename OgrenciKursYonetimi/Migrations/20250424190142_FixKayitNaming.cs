using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciKursYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class FixKayitNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitId1",
                table: "KursKayitlar");

            migrationBuilder.RenameColumn(
                name: "KursKayitId1",
                table: "KursKayitlar",
                newName: "KursKayitKayitId");

            migrationBuilder.RenameColumn(
                name: "KursKayitId",
                table: "KursKayitlar",
                newName: "KayitId");

            migrationBuilder.RenameIndex(
                name: "IX_KursKayitlar_KursKayitId1",
                table: "KursKayitlar",
                newName: "IX_KursKayitlar_KursKayitKayitId");

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitKayitId",
                table: "KursKayitlar",
                column: "KursKayitKayitId",
                principalTable: "KursKayitlar",
                principalColumn: "KayitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitKayitId",
                table: "KursKayitlar");

            migrationBuilder.RenameColumn(
                name: "KursKayitKayitId",
                table: "KursKayitlar",
                newName: "KursKayitId1");

            migrationBuilder.RenameColumn(
                name: "KayitId",
                table: "KursKayitlar",
                newName: "KursKayitId");

            migrationBuilder.RenameIndex(
                name: "IX_KursKayitlar_KursKayitKayitId",
                table: "KursKayitlar",
                newName: "IX_KursKayitlar_KursKayitId1");

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitId1",
                table: "KursKayitlar",
                column: "KursKayitId1",
                principalTable: "KursKayitlar",
                principalColumn: "KursKayitId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciKursYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class FixKursKayitKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KayitId",
                table: "KursKayitlar",
                newName: "KursKayitId");

            migrationBuilder.AddColumn<int>(
                name: "KursKayitId1",
                table: "KursKayitlar",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KursKayitlar_KursId",
                table: "KursKayitlar",
                column: "KursId");

            migrationBuilder.CreateIndex(
                name: "IX_KursKayitlar_KursKayitId1",
                table: "KursKayitlar",
                column: "KursKayitId1");

            migrationBuilder.CreateIndex(
                name: "IX_KursKayitlar_OgrenciId",
                table: "KursKayitlar",
                column: "OgrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitId1",
                table: "KursKayitlar",
                column: "KursKayitId1",
                principalTable: "KursKayitlar",
                principalColumn: "KursKayitId");

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlar_Kurslar_KursId",
                table: "KursKayitlar",
                column: "KursId",
                principalTable: "Kurslar",
                principalColumn: "KursId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KursKayitlar_Ogrenciler_OgrenciId",
                table: "KursKayitlar",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlar_KursKayitlar_KursKayitId1",
                table: "KursKayitlar");

            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlar_Kurslar_KursId",
                table: "KursKayitlar");

            migrationBuilder.DropForeignKey(
                name: "FK_KursKayitlar_Ogrenciler_OgrenciId",
                table: "KursKayitlar");

            migrationBuilder.DropIndex(
                name: "IX_KursKayitlar_KursId",
                table: "KursKayitlar");

            migrationBuilder.DropIndex(
                name: "IX_KursKayitlar_KursKayitId1",
                table: "KursKayitlar");

            migrationBuilder.DropIndex(
                name: "IX_KursKayitlar_OgrenciId",
                table: "KursKayitlar");

            migrationBuilder.DropColumn(
                name: "KursKayitId1",
                table: "KursKayitlar");

            migrationBuilder.RenameColumn(
                name: "KursKayitId",
                table: "KursKayitlar",
                newName: "KayitId");
        }
    }
}

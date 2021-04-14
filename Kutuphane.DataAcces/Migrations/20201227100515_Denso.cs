using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kutuphane.DataAccess.Migrations
{
    public partial class Denso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kitapAd = table.Column<string>(type: "TEXT", nullable: true),
                    kitapSayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    kitapYazari = table.Column<string>(type: "TEXT", nullable: true),
                    kitapRaftami = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ogrenciAd = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciEposta = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciTelefon = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciNumarası = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciSifre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emanet",
                columns: table => new
                {
                    emanetNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciId = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmanetVermeTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetGeriAlmaTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetIslemTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetTeslimEdildi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emanet", x => x.emanetNo);
                    table.ForeignKey(
                        name: "FK_Emanet_Kitap_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emanet_Ogrenci_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emanet_KitapId",
                table: "Emanet",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Emanet_OgrenciId",
                table: "Emanet",
                column: "OgrenciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emanet");

            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}

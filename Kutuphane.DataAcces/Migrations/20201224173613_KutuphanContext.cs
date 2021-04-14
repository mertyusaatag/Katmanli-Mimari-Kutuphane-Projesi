using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kutuphane.DataAccess.Migrations
{
    public partial class KutuphanContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kitaps",
                columns: table => new
                {
                    kitapNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kitapAd = table.Column<string>(type: "TEXT", nullable: true),
                    kitapSayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    kitapYazari = table.Column<string>(type: "TEXT", nullable: true),
                    kitapRaftami = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaps", x => x.kitapNo);
                });

            migrationBuilder.CreateTable(
                name: "ogrencis",
                columns: table => new
                {
                    ogrenciNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ogrenciAd = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciEposta = table.Column<string>(type: "TEXT", nullable: true),
                    ogrenciTelefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrencis", x => x.ogrenciNo);
                });

            migrationBuilder.CreateTable(
                name: "emanets",
                columns: table => new
                {
                    emanetNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ogrenciNo = table.Column<int>(type: "INTEGER", nullable: false),
                    kitapNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EmanetVermeTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetGeriAlmaTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetIslemTarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmanetTeslimEdildi = table.Column<string>(type: "TEXT", nullable: true),
                    kitapNo1 = table.Column<int>(type: "INTEGER", nullable: true),
                    ogrenciNo1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emanets", x => x.emanetNo);
                    table.ForeignKey(
                        name: "FK_emanets_kitaps_kitapNo1",
                        column: x => x.kitapNo1,
                        principalTable: "kitaps",
                        principalColumn: "kitapNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_emanets_ogrencis_ogrenciNo1",
                        column: x => x.ogrenciNo1,
                        principalTable: "ogrencis",
                        principalColumn: "ogrenciNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emanets_kitapNo1",
                table: "emanets",
                column: "kitapNo1");

            migrationBuilder.CreateIndex(
                name: "IX_emanets_ogrenciNo1",
                table: "emanets",
                column: "ogrenciNo1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emanets");

            migrationBuilder.DropTable(
                name: "kitaps");

            migrationBuilder.DropTable(
                name: "ogrencis");
        }
    }
}

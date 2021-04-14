using Microsoft.EntityFrameworkCore.Migrations;

namespace Kutuphane.DataAccess.Migrations
{
    public partial class _2db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kullanıcıs",
                columns: table => new
                {
                    KullanıcıID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kullanıcıUserName = table.Column<string>(type: "TEXT", nullable: true),
                    kullanıcıPassword = table.Column<string>(type: "TEXT", nullable: true),
                    k_ogrenciNo = table.Column<int>(type: "INTEGER", nullable: false),
                    ogrenciNo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanıcıs", x => x.KullanıcıID);
                    table.ForeignKey(
                        name: "FK_kullanıcıs_ogrencis_ogrenciNo",
                        column: x => x.ogrenciNo,
                        principalTable: "ogrencis",
                        principalColumn: "ogrenciNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kullanıcıs_ogrenciNo",
                table: "kullanıcıs",
                column: "ogrenciNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kullanıcıs");
        }
    }
}

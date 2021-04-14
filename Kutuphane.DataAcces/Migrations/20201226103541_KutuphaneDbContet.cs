using Microsoft.EntityFrameworkCore.Migrations;

namespace Kutuphane.DataAccess.Migrations
{
    public partial class KutuphaneDbContet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ogrenciNumarası",
                table: "ogrencis",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ogrenciNumarası",
                table: "ogrencis");
        }
    }
}

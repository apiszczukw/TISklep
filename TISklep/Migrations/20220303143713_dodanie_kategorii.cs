using Microsoft.EntityFrameworkCore.Migrations;

namespace TISklep.Migrations
{
    public partial class dodanie_kategorii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Horror", "Straszne filmy" },
                    { 2, "Dokumentalne", "Filmy oparte na faktach" },
                    { 3, "Thriller", "Dreszczowce" },
                    { 4, "Sensacyjne", "Filmy z akcją" },
                    { 5, "Fantasy", "Elementy magiczne i nadprzyrodzone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategorie",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

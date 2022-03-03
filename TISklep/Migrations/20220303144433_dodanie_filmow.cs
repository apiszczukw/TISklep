using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TISklep.Migrations
{
    public partial class dodanie_filmow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataProdukcji", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.", "Marcus Nispel", "Teksańska Masakra Piłą Mechaniczną" },
                    { 2, 14m, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.", "Joel Schumacher", "Numer 23" },
                    { 3, 12m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.", "David Koepp", "Sekretne Okno" },
                    { 4, 20m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.", "Peter Jackson", "Władca Pierścieni: Drużyna Pierścienia" },
                    { 5, 11m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.", "Robert Schwentke", "Red" },
                    { 6, 0m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.", "Tomasz Sekielski", "Tylko nie mów nikomu" },
                    { 7, 13m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.", "Neil Burger", "Iluzjonista" },
                    { 8, 15m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.", "Vincenzo Natali", "Cube" },
                    { 9, 16m, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.", "Clive Barker", "Hellraiser: Wysłannik Piekieł" },
                    { 10, 17m, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.", "Jonathan Demme", "Milczenie Owiec" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

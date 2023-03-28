using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08EVV2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3X843D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "633VJ6");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "7I2A28");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "817264");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "Y26O47");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "72GSM5", 0, "c131794a-8a37-4697-b0d2-1014e6c1b66b", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEBhFnyE9ZdOUymeQXUVp5aQY77ej7bD7LbQUp7/F4gc5MUvqZSwhCySfCDDrttmArQ==", null, false, "1613508d-50f1-453a-80b3-a598ec6bc636", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "E7J08X", 0, "94d12c2d-5c4f-4ddc-91de-5302af773bc2", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEK24QzXAv8YTlsec0XJuO4vkrp+VTLiAyKz3EI84XNQi+gbRLNsQemYV8DOuHXrp4g==", null, false, "f433fda7-3858-42d0-bdd5-b5002c3be259", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "P6KJIF", 0, "bbafe294-1a81-48d3-893a-a97498d5c939", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEO3H60tes1yhLVcAYytQLZxiwE7A/wiBIB+2fRmRhTIPaLF32obVjSAMmjOwPFJMVw==", null, false, "8bc49bb7-4f50-416a-b2cc-0dc48b617e51", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "8YWS4H", "NIK", "Bsc", "Nyári Dalma" },
                    { "CW5584", "NIK", "Bprof", "Huba Árpád" },
                    { "N2CA1I", "NIK", "Bsc", "Török Levente" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72GSM5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E7J08X");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "P6KJIF");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8YWS4H");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "CW5584");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "N2CA1I");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "08EVV2", 0, "15331de9-4dec-44be-8e72-e0f4f5a322b3", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEPq74wZa+EV4KDwj43ixzpqKA61cxvEgOJONuPf0kb0SkYwrO5Vx7+gvriU77/SrnA==", null, false, "eee9f979-f131-497d-9e4d-68cfedf72086", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "3X843D", 0, "7d0257b5-ed9f-4f20-8e50-9e668f65cf66", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEHuWcvrNX0e8EcTLjOFb8yqdsNrJpnzpWdhGW+gehHQR7Zqq7BzEKajvfS8gwqW1wg==", null, false, "f7211c11-80b2-4809-bad7-9b8483567333", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "633VJ6", 0, "8b70b78e-6253-47d0-a881-2bd651a02e27", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEFnjHhyfl3V22UWhPLcBNMJGEla7pjBnNLXrgvsCm8x6AZC4tVgSOvUsX5XIPVVfVA==", null, false, "987a64de-628a-4630-b8c7-81cb1fb5d838", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "7I2A28", "NIK", "Bsc", "Nyári Dalma" },
                    { "817264", "NIK", "Bsc", "Török Levente" },
                    { "Y26O47", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

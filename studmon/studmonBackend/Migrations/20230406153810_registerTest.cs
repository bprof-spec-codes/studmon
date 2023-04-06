using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class registerTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Tanar", "TANAR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "4O3N2O", 0, "d2a4b9a2-c8ea-4fad-a9de-861d7c5a3bad", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEAPaVOCwb3WybaDZ90O6A7OZDwGM4rrKA66XTVC2adKBoLiMBZUEHHmVTt8VXJkSCQ==", null, false, "f18382db-1e40-45e8-b5f9-85a39e1feacc", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "71P25C", 0, "d87c951a-3b36-41f1-aa19-dc1acec78052", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEMR6oXpGQZT9jGussRYnJamdpxZuPnXLaqwAZlKC7aaGcATWIfEXwTbqoNVLl0rs4w==", null, false, "f5c3460e-7b92-4e05-86c4-77dfededa78d", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "EQ702S", 0, "dbbb1050-02a8-4800-aec6-9612b547970c", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEEXEOD8QIt/4Z/GSioKUucp5UWpWZtEjGQYfOB5M8aC17tATym6HofHCpsvQu66qLA==", null, false, "f3cca9e8-7c0c-48d8-bff2-55b11419e69f", false, "balogh.attila@gmail.com", "Balogh Attila" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "5VDK00", "NIK", "Bprof", "Huba Árpád" },
                    { "84167Q", "NIK", "Bsc", "Török Levente" },
                    { "RY15SY", "NIK", "Bsc", "Nyári Dalma" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4O3N2O");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71P25C");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "EQ702S");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "5VDK00");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "84167Q");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "RY15SY");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Customer", "CUSTOMER" });

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
    }
}

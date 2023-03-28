using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4GSNWM");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68MF3I");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "KY4O36");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "2T5E16");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8KXG55");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "WK212T");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4GSNWM", 0, "26e15f25-d21a-4776-8428-df680046e38a", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEENNmyO3glCumAIDNAaxB0JMkUSASp4Hn/r7+G5uViT9ekhzzXgLfZ+2oKsJoakc8A==", null, false, "26ad3660-6d27-44f7-bb32-aefa8fa7f247", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "68MF3I", 0, "2c004c64-bfe9-47e4-92d9-1876568c6156", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEGM/MJ6KemKkidwmABq/dfamYILCya2YNK6VfOhF8PBgGfK8POgtHYxryaB49yX20Q==", null, false, "ffda9963-8992-417a-8f97-ca9c1b93bce3", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "KY4O36", 0, "96164713-922c-434f-b650-0e0d9f677b22", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAENvEdyqBV42GBoBggyv2BNItDY9aFqOLH9vgF5i4j6aC0ND65/RtxDMgEBIpm1RYyA==", null, false, "f76da61c-2ad9-4b5b-a1b6-291baeec1b86", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "2T5E16", "NIK", "Bsc", "Nyári Dalma" },
                    { "8KXG55", "NIK", "Bprof", "Huba Árpád" },
                    { "WK212T", "NIK", "Bsc", "Török Levente" }
                });
        }
    }
}

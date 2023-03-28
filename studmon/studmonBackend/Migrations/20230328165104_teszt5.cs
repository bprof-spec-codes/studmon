using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6124VU");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ER56L");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "742007");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "0A211J");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "VTXJB7");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "XTHNIO");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "6124VU", 0, "779f6a6d-389d-4bd1-9acf-e0224f6821b2", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEFVt9V55TTRtIU+eSLEe+VOCrQtvYSr82ik7jvanP/7mUiAlmAowE6v4Y33YJ1NaYQ==", null, false, "db994eac-fbe7-46e7-987a-8a9dd539242a", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "6ER56L", 0, "f25b0759-18d1-44c2-b2ec-ac30d771a9fb", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEDREhBKyQBHXwRLXb5ok0+Nu9gIrXzevZo7aBvy3G7fGY/YB0vrc/3mWzBIcodCnZw==", null, false, "bcddeefe-48b6-4bfc-a526-f04e36c4b5c7", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "742007", 0, "7d52aae7-8470-4313-b369-04e187446a6d", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEKT2Xtg6V9hybj9rQ0dUV6DFLyXcq7NHE/FTwLwgxdO9tFJg8Iz6U0CWyud5q3bTuw==", null, false, "baf9f2e8-0863-4567-a609-7c62d13b96cd", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "0A211J", "NIK", "Bsc", "Nyári Dalma" },
                    { "VTXJB7", "NIK", "Bsc", "Török Levente" },
                    { "XTHNIO", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

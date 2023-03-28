using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmon.Migrations
{
    public partial class rebasedBandi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091f3fab-05a2-48da-9d00-ac34909014fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17c429f4-a6f3-4328-b66a-5bdf2d8514ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf6c4d3-8794-4cec-a707-6772c5d27b4e");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "572OA2");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "6F5036");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "FT6DQB");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "19e0c359-f7e9-403a-9fde-5a086e84993e", 0, "9e52b7cf-cf45-4ca6-b9fc-19b585196a3a", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEK0VPhJjQGt2pjIjE3GJx0q7/EeYrIk+FJ1hl8HLlkLNuNCHkc14Myq7Nyz+gkwVWQ==", null, false, "6215a916-4519-4c8a-9404-6fc4ff135fbb", false, "horvath.karoly@gmail.com", "2ARR68", "Horváth Károly" },
                    { "3c0d193f-e46b-40c5-945a-9b487e8b9171", 0, "69ae8cfd-78a0-40ad-9b1b-71457ad33e65", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEE5KfyNcH2Of2TUZvVpsFlAL8jMWxN19NF63zZDTgTS5d0vTAkImpt623YSovDgJsw==", null, false, "a3eb07dd-bb6a-4bd0-b90f-9d265aaadefe", false, "toth.angela@gmail.com", "058238", "Tóth Angéla" },
                    { "c7322225-b2cb-4069-a16e-6e15e4c58ed5", 0, "effddbb4-107a-451a-b41d-ec5d10fbc80d", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEPLE4rJPfYcnaFJWW21CCZX39qnwOzjfWMKXzoRmQo2SvjFZRdzV7mp2AVm9dkbGVQ==", null, false, "35d3fd79-e710-4adb-9c82-bd69d7b1990f", false, "balogh.attila@gmail.com", "80K41S", "Balogh Attila" }
                });

            migrationBuilder.InsertData(
                table: "hallgatoTabla",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "61M2N8", "NIK", "Bprof", "Huba Árpád" },
                    { "7N564N", "NIK", "Bsc", "Nyári Dalma" },
                    { "KXK4FI", "NIK", "Bsc", "Török Levente" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e0c359-f7e9-403a-9fde-5a086e84993e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c0d193f-e46b-40c5-945a-9b487e8b9171");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7322225-b2cb-4069-a16e-6e15e4c58ed5");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "61M2N8");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "7N564N");

            migrationBuilder.DeleteData(
                table: "hallgatoTabla",
                keyColumn: "neptunKod",
                keyValue: "KXK4FI");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "091f3fab-05a2-48da-9d00-ac34909014fc", 0, "8ae90619-2759-4eed-a41c-719a3aae58f4", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEPhZrxubUF5uVqw6WjMeh91eY9ElHLlQARoSIbomc2pUK+dVXabLp8bmDf5HDw0BXQ==", null, false, "da3d5bbf-b16e-40b7-8cbe-b9acdf9f3426", false, "balogh.attila@gmail.com", "3RD84P", "Balogh Attila" },
                    { "17c429f4-a6f3-4328-b66a-5bdf2d8514ed", 0, "7c6a8090-61b5-4999-8d0a-9ae2ef4e8f27", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEOGIPhhumsdSXrYt4PtxSgnJLMa3+VH+/igUYjvYxV2WCBEytx1rF7ijd9orl8TkIg==", null, false, "4ef33169-21da-443b-b542-1007b56abb46", false, "horvath.karoly@gmail.com", "3AL1C1", "Horváth Károly" },
                    { "6bf6c4d3-8794-4cec-a707-6772c5d27b4e", 0, "60b7a7e9-ebea-4d9d-a92b-32cb839baba3", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEPHuibsJ0wwBtW8OzRUlzSuKyDaz3H1XVrNelcgSeB3Z6LKefpXxFVLLUoLE+vW/WA==", null, false, "6c735400-c3e4-442b-a9e4-b603ca5de48e", false, "toth.angela@gmail.com", "6RL3QX", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "hallgatoTabla",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "572OA2", "NIK", "Bsc", "Török Levente" },
                    { "6F5036", "NIK", "Bprof", "Huba Árpád" },
                    { "FT6DQB", "NIK", "Bsc", "Nyári Dalma" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1D0871");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5UPFAM");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "PH4YX8");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "542168");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8161G4");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "UFS2CN");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1D0871", 0, "6e834d0a-4516-4e28-8016-efd58e4d9b3b", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEPxiA7Y+/vGmCyqzKDtCuWIEyO+PA80KEp4XH9YpM/iTJyIHS6c8y45Ij+60/el/JA==", null, false, "9cb6d2b5-a060-47a6-a0a1-97feb5eef8ba", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "5UPFAM", 0, "0e28c916-7f90-4ee4-80eb-4a9af00549e4", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEGtfjGQ3PJ/cJjPWYvMCNZPmWspX0Ot9nCE40t7axlVQfvvSbjRQhdedQolnKzM+2Q==", null, false, "3505afe9-b4fd-4c6f-bab1-bf373bda91d3", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "PH4YX8", 0, "eaf52d82-19c4-4ed1-98f0-745658404ce4", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEJsYZ2Nx8Kv/dJNreT05Hz5Fz+0QQj4TNaiJvI0mqUhATzSl1ruYMKR9+vjNKlrd4A==", null, false, "01503db9-87d4-4365-9935-70fd038e9902", false, "toth.angela@gmail.com", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "542168", "NIK", "Bprof", "Huba Árpád" },
                    { "8161G4", "NIK", "Bsc", "Nyári Dalma" },
                    { "UFS2CN", "NIK", "Bsc", "Török Levente" }
                });
        }
    }
}

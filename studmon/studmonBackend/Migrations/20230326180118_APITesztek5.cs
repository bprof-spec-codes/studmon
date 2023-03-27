using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class APITesztek5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4B410A");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BQT8SO");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "O54651");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "0R21O1");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "256542");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "R3438Q");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "06O7TE", 0, "3dbeec4c-6aa9-4719-941e-144fe1772c73", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEL4SfBRI9USK86N7EDROoBz08nIDMNjF/6GD4MHeXuJJ8X8vHiv+T7mwK/xEzRR7Fg==", null, false, "07aa2e76-e1c9-4d9b-9fd6-9c88077a26db", false, "horvath.karoly@gmail.com", "06O7TE", "Horváth Károly" },
                    { "28F3K3", 0, "f1943b17-e190-461b-a5f1-ef178b0084e3", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAELxJF9YvhJu1MEHhRmAqeLQh6busjPf8eqOE+hBWiqRCIigbQgNsRWybu7FZhebU+w==", null, false, "c179e316-280a-4d30-9aee-08aee2c5d88c", false, "toth.angela@gmail.com", "28F3K3", "Tóth Angéla" },
                    { "XY5T67", 0, "648a5a14-2b5a-425d-b352-b2936cec126c", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEL94mWdLkzdVm0n4cM9gSlxXk9kTN55Ca7Ea+zdbVpVrwn5c4wm0OKneYNV3NDqPxg==", null, false, "84fc5884-4847-4164-91fa-00ae233a42d5", false, "balogh.attila@gmail.com", "XY5T67", "Balogh Attila" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "01815O", "NIK", "Bsc", "Török Levente" },
                    { "112537", "NIK", "Bsc", "Nyári Dalma" },
                    { "3G5AH8", "NIK", "Bprof", "Huba Árpád" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06O7TE");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28F3K3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XY5T67");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "01815O");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "112537");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "3G5AH8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "4B410A", 0, "bc513255-9197-45c4-8868-3b2002c663ff", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEAS/Pn1QT1f1aB9twis9frF6xt4iAhply3QE4h7eIIeFgI6KDcw+ycS5kUqKH1pgXg==", null, false, "c38cf0a6-450d-4d68-9370-4a165a5f8e7d", false, "balogh.attila@gmail.com", "4B410A", "Balogh Attila" },
                    { "BQT8SO", 0, "10790ec9-872a-4a7a-8250-6ccfcae4fe48", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEMbru6fwiRrOz1OIyM2hbhjoyeNHwrdZicakmMZcCPniV0BVUqZ0aSXEa1cdTXKFsg==", null, false, "1c7fdd22-e314-44d6-a2f1-8eb2174e19d6", false, "horvath.karoly@gmail.com", "BQT8SO", "Horváth Károly" },
                    { "O54651", 0, "29f0e566-cdc6-4f61-b4af-78bb3de18727", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEFmEq3Sk6mmebpE7Mdba1KKGuIGBL8md4e/Dt9y9AV7XwF+2MehTDR6iwS0K+SZo3w==", null, false, "b5bf2410-594d-4330-8db5-4958113d0a6b", false, "toth.angela@gmail.com", "O54651", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "0R21O1", "NIK", "Bsc", "Török Levente" },
                    { "256542", "NIK", "Bsc", "Nyári Dalma" },
                    { "R3438Q", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class APITesztek4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "OTP2QY");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "W1Q6J7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "WO5HS1");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "3165M8");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8FFC28");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "M8D5A8");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "OTP2QY", 0, "27f3806b-420f-4a23-b766-820f6a847ff7", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEE0gSW4b8QpiScsREiZBVp5l6RHFs2/ucZdOjGdVNwZ469ViRVWBhT3GIvowh5RL8g==", null, false, "1d2db1a2-5608-4ce7-8d4d-7546a248b409", false, "horvath.karoly@gmail.com", "OTP2QY", "Horváth Károly" },
                    { "W1Q6J7", 0, "3c10214d-124e-480c-87b9-a0fa29023832", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAENEodv30ZP4SUEFplEtpY6fX/jfXwNnMcNZvjfC+e+a8AeFya9MzofqdwU5hy65Tag==", null, false, "07ebb81c-eb02-418c-bb5b-35fb3c14be33", false, "toth.angela@gmail.com", "W1Q6J7", "Tóth Angéla" },
                    { "WO5HS1", 0, "78b2ac8d-65f2-4d3d-8bf8-d8bd468c46d4", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEP039saAKYoJK/BOCtxsJjynFVjzTq8e+56wXXdctmHa9ERmfbOVJpbJNrcjITpApg==", null, false, "1ad0e68e-3547-47d9-9bd9-3da2de08cf39", false, "balogh.attila@gmail.com", "WO5HS1", "Balogh Attila" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "3165M8", "NIK", "Bsc", "Nyári Dalma" },
                    { "8FFC28", "NIK", "Bprof", "Huba Árpád" },
                    { "M8D5A8", "NIK", "Bsc", "Török Levente" }
                });
        }
    }
}

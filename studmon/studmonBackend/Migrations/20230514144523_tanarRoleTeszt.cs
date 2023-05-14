using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class tanarRoleTeszt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87TPKG");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "OO61C4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "RG107V");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "UQ4887");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "X6HY8H");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "YV4PQU");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "05LGSG", 0, "0ac491ee-f192-4c28-ad32-b33ae327bbe7", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEPS28lZG/c/fcH4jq6SLHsQU8j3Wuiqzs2pGHwlU54fw641Jbgqb3AXu2RVDS5/4bQ==", null, false, "a34b3735-e02c-46c9-adff-62831171d660", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "74Q8OP", 0, "3f1725de-a8b5-48d2-8027-81fc8b61f593", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEMiu3Z2fUIUZ3Zb8Cb0+4cry0d4No69KBOKI2FK/z4irrd7KQ4yRD/DadGo9MElgIQ==", null, false, "29dbb80c-8609-4f53-b168-f1357d38fc6c", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "85QGJY", 0, "cda9cbeb-648c-4a4d-9339-f3c943e93be3", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEBc4HIGYkn6dJ1i9Um9Oz5n5xhQ6psBkguYRcHrGAqRPtk/89LA5EvMb0FQQKKIosA==", null, false, "051b5d6d-cada-479e-a15a-c41474a20d82", false, "toth.angela@gmail.com", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "4GX644", "NIK", "Bsc", "Nyári Dalma" },
                    { "7SVOXL", "NIK", "Bprof", "Huba Árpád" },
                    { "8M70X1", "NIK", "Bsc", "Török Levente" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "05LGSG" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "74Q8OP" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "85QGJY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "05LGSG" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "74Q8OP" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "85QGJY" });

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "4GX644");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "7SVOXL");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8M70X1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05LGSG");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74Q8OP");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85QGJY");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "87TPKG", 0, "5e4df9b7-4db3-406c-b0d1-9b7db587ee09", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEHcKUduQEuygefU3ENQn1n+EErouCOUGvp9YNt47ctP3KWsteKCEp8jukE0/7xgwZg==", null, false, "2e2852c6-c6a2-4a5f-bf85-cfd5b2ebdfb6", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "OO61C4", 0, "4734c4ce-e090-45c5-ac72-985d9678f992", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEDL+Zd+chGg1HEHiACi4rJ29XiP3lKWd0466aznUiXlHubprQhDQ4XD7xSM3J47Fwg==", null, false, "a37c571e-2548-4c5f-8999-37ef508c3d5d", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "RG107V", 0, "e5d77619-1625-46a2-9408-f9fbfc01e1b3", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEPiGj36CHCCdhXTjcBHjZbDu2ieai1PUBlXFUFsDjZ5/nw6+SvBatmYJQZWG9h/Ceg==", null, false, "0ae1422c-59ce-4e94-8b38-14fc2f411989", false, "balogh.attila@gmail.com", "Balogh Attila" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "UQ4887", "NIK", "Bsc", "Nyári Dalma" },
                    { "X6HY8H", "NIK", "Bsc", "Török Levente" },
                    { "YV4PQU", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

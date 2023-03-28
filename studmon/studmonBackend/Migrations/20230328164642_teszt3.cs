using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46W141");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D11AH6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "O71500");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "002535");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "2N1863");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "5035HW");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "46W141", 0, "a85020e8-138f-45e4-8672-2d7766d81592", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEJiN3i3ffkrkDGApi6pnKx8VLjXEU3VtucDhqr5D/trCxuVJ9sf4cSZ7ATUUNv+Gdw==", null, false, "f9229970-72ac-4a2f-bc81-30a80433cef2", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "D11AH6", 0, "e148e44d-002f-47d8-b62c-e9b5a55ea829", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEHX0eCkl0KX+FiVtze0kDvoH1bZshRNKYs4CVXS3rRVTanaRMTsDijp7RfCcjUNn1w==", null, false, "49421f12-336c-4946-a946-76f9f7c9d69a", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "O71500", 0, "8ea69bf1-103d-46b4-8374-b12f757296c2", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEDFqNe7q6xmfasCrHYPLdVBS8v7dwjcdtGTp7UCxUBM/bdUjZlZ0oo+S/l7qZ0rjkQ==", null, false, "b229942b-5945-4c5f-9cb7-f7def71afb38", false, "toth.angela@gmail.com", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "002535", "NIK", "Bsc", "Török Levente" },
                    { "2N1863", "NIK", "Bprof", "Huba Árpád" },
                    { "5035HW", "NIK", "Bsc", "Nyári Dalma" }
                });
        }
    }
}

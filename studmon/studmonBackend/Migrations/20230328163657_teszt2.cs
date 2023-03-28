using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teljesitmenyek",
                table: "Teljesitmenyek");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40BB54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BU5IWQ");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "JNG763");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "14HG88");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "65Y420");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "W5F04I");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Teljesitmenyek");

            migrationBuilder.AddColumn<string>(
                name: "teljesitmenyID",
                table: "Teljesitmenyek",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teljesitmenyek",
                table: "Teljesitmenyek",
                column: "teljesitmenyID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teljesitmenyek",
                table: "Teljesitmenyek");

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

            migrationBuilder.DropColumn(
                name: "teljesitmenyID",
                table: "Teljesitmenyek");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Teljesitmenyek",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teljesitmenyek",
                table: "Teljesitmenyek",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "40BB54", 0, "2b3adb59-f129-4551-86b7-a66e8ff0177c", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEO0XVEemBZY0jVIrg0iLnbUSIW0CSfeCde3J7iXWILHZrBvzHI9yIcCWFAIjZ4SopA==", null, false, "0b2b8cc4-a5c8-4dd0-b60b-b1c786ea23f3", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "BU5IWQ", 0, "4e18f756-d7d5-4e0e-b200-7ae78cfe7218", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAECBQyOTxtPFtX5BafiIxaK0N1sCNA/fifawOxTcytni6Llcey6abu1+nWPc9Ev8tow==", null, false, "7ee52b83-ae35-4e18-9ab0-fc8a69b7b0d0", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "JNG763", 0, "6b45c020-fb72-44f3-a522-f3af179bbfcf", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEE1E6drI3ZQyt6ANLrSXtPwT6KmoJZoOri8K+h4VzODvR3OF1D9f2J0xgyY4qNG8XA==", null, false, "b5a6d2af-f904-40e4-8f5f-b8706cca951b", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "14HG88", "NIK", "Bsc", "Nyári Dalma" },
                    { "65Y420", "NIK", "Bsc", "Török Levente" },
                    { "W5F04I", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

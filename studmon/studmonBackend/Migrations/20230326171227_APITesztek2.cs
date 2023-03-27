using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class APITesztek2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d0aec10-b6a7-4974-817f-c0115aa2f6bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d4e6f0a-0ab8-40da-87d8-50bccf1a3466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fbae3d-06b8-43cd-92a2-47ac74eeff0c");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "38XN6D");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "560Y78");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "YYSRGQ");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "025327", 0, "d782a385-c3da-4fd4-9fc3-effaa748dc8d", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEISHCpiCJZQ12WS+2I68g2UfKLplFflgM/ec8tZE3/Y8tVgQzlykXo9Kh/jVE7fo1Q==", null, false, "b8a07fd2-fd43-40ae-9dcf-762a4162dce9", false, "balogh.attila@gmail.com", "025327", "Balogh Attila" },
                    { "421O04", 0, "27766a16-d00c-4c90-9960-c11197d2420c", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEO7/+VXeH37mOSHJ8teULmAPQhNu8d0L90uNGE0Dre9xOtJDwbGTFvB0LGLFmaxHAw==", null, false, "a51fce65-61d0-4950-9d3f-c516f4603bb6", false, "horvath.karoly@gmail.com", "421O04", "Horváth Károly" },
                    { "4P058J", 0, "5ee3f27f-53c9-482c-bddd-8e55e7781da2", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEFIPquiSQXi1tALYIB5M5eok60SDp+gXrFftiOQhJqmP/ddi2wJ9dDtSR6S/rzbrVw==", null, false, "61a337f8-8234-4029-bd4b-4eacac2b7fa0", false, "toth.angela@gmail.com", "4P058J", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "P027CY", "NIK", "Bprof", "Huba Árpád" },
                    { "R35TJN", "NIK", "Bsc", "Nyári Dalma" },
                    { "U35626", "NIK", "Bsc", "Török Levente" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "025327");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "421O04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4P058J");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "P027CY");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "R35TJN");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "U35626");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "neptunKod", "nev" },
                values: new object[,]
                {
                    { "1d0aec10-b6a7-4974-817f-c0115aa2f6bd", 0, "f8b2c79a-a7fe-4ea1-93cc-0232462745fc", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEFQwOY5/2DuhpfUDd6uhOqtyn18JpsK/09vjBDvbC0v7wB7FxwBllUFSw65ZhK3NFg==", null, false, "ca683eec-1c1c-4ff2-9fb8-f3ab0ce9820e", false, "balogh.attila@gmail.com", "EMTVN0", "Balogh Attila" },
                    { "1d4e6f0a-0ab8-40da-87d8-50bccf1a3466", 0, "abbac1cd-7c65-4430-b5ee-15fd58b006fc", "horvath.karoly@gmail.com", false, false, null, "HORVATH.KAROLY@GMAIL.COM", "HORVATH.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEPOVNodEclJLryXLCXicxId8fWGHakiPIGkKKNVXpK659IUXXyQ2tDkxEU4cWGOFkA==", null, false, "f14519d3-18e0-4125-973e-906e3bc4eea9", false, "horvath.karoly@gmail.com", "PB4E02", "Horváth Károly" },
                    { "93fbae3d-06b8-43cd-92a2-47ac74eeff0c", 0, "86e2b833-851a-47cc-a343-6ebbfd7cfcb8", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEOU6nBvucejR5gsnnrHx0umDBdJUSJnC+4PJwButj1nUs8nmpvA04QIphQ+IGA0VLA==", null, false, "6a8b3a67-bec1-4297-95ec-7470b467ade2", false, "toth.angela@gmail.com", "DQ117C", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "38XN6D", "NIK", "Bsc", "Török Levente" },
                    { "560Y78", "NIK", "Bprof", "Huba Árpád" },
                    { "YYSRGQ", "NIK", "Bsc", "Nyári Dalma" }
                });
        }
    }
}

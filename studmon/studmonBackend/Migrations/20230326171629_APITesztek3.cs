using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class APITesztek3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

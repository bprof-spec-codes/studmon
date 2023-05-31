using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DFG234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d99ea350-66a9-4636-9739-f7a5464c18de", "AQAAAAEAACcQAAAAEMSd7+vgjLtPYh37gekbJT2nklOy4k+fctRy866jdhTL1dBP7vmgNYaHhKV66S0sRg==", "4761eb2d-d152-4920-ac58-360c3f8acb09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a500cfa-f59f-4ab5-8a67-7d6112dd407b", "AQAAAAEAACcQAAAAEJPR4AY24qMcWGxtPUtnlYb1k/aQkSPTAdt8MElhr7bS94OCec8AsiDm9eo3L+NDOQ==", "e6cf7406-bea2-4003-af91-6645973e71e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XY2345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41185570-e3a4-4dc8-82a2-ced743221099", "AQAAAAEAACcQAAAAEOyolPGzgNntFTPB+hUTVuPjl1aaIBTh9Nyi6qYxZxSfw33i0sYRTdVY4B0POTcMqw==", "b9654dd5-9d57-46f5-94d9-1971b4a55f91" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[] { "ADMIN1", 0, "3f72577c-c63a-4a32-8d51-1f56d85533e9", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOWTXibG6UpdQkSBitSkR7eLF4Q3U7mteFwIGqF9NUV1dcBPbXWg68rhgrUMQr/9/A==", null, false, "c869dc91-cd86-40a8-b767-d39087e3b96a", false, "admin@gmail.com", "Admin" });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD123",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 38, 10, 419, DateTimeKind.Local).AddTicks(8167), new DateTime(2023, 5, 31, 19, 38, 10, 419, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD234",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 38, 10, 419, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 5, 31, 19, 38, 10, 419, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD345",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 38, 10, 419, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 5, 31, 20, 38, 10, 419, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ADMIN1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ADMIN1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DFG234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec0d3afc-c933-4121-97cc-671f9d92cc1a", "AQAAAAEAACcQAAAAEBlrmyYZrufeaJaJVGLu10kfuSn9k0jGTZT+bXL2oBmY3sWQdAGn4wbwe3gJwxdBZQ==", "1632ffb6-bb03-4bfb-acd5-0fbef4996f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "447afb34-5bd2-43f2-b023-da70810f1832", "AQAAAAEAACcQAAAAEDX+IFC8359bQveXCcS7tS4pkpPt+AEyUpefoAMofiTGzEJ6pevjKauuSLohKmBG9A==", "197ddf6b-6831-43ef-9338-80a64ea931b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XY2345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "881640c3-585c-429a-b4f0-5acd8d03d8f9", "AQAAAAEAACcQAAAAEGgN6LIEJjQkIooJjNeZlZB0k/nxrhBqm52yzliZhrxL/UmYIeikM2GfuYHW6HLZaQ==", "8a99304e-37c5-41c6-9521-32be225af474" });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD123",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 12, 24, 123, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 5, 31, 16, 12, 24, 123, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD234",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 12, 24, 123, DateTimeKind.Local).AddTicks(1753), new DateTime(2023, 5, 31, 16, 12, 24, 123, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD345",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 31, 15, 12, 24, 123, DateTimeKind.Local).AddTicks(1758), new DateTime(2023, 5, 31, 17, 12, 24, 123, DateTimeKind.Local).AddTicks(1759) });
        }
    }
}

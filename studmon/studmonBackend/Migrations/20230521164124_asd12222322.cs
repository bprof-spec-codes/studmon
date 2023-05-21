using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class asd12222322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ertekeles",
                table: "Teljesitmenyek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DFG234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3704cd4-2f2f-4306-80a0-78ee31f2a4a6", "AQAAAAEAACcQAAAAEIBX/jEbnBdqaR0yp1ffnDZFDzfsRXh9Ue32y1DgqVQG7bNV7O20naY4FpvaNyUljw==", "17667d47-1010-44af-af40-5b5a71cf1204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a4012b2-676d-4ec0-8ab6-21b3eb9c11dc", "AQAAAAEAACcQAAAAEG20uZmTdRXP3ojRSvcXeTRNAm+MsFALuAa+zeoSvyCNRUKgW9gXl2i2RKhT7zSUdg==", "320e4f14-0089-4bda-bc3c-6536db5707b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XY2345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dd31a19-6175-4e6c-af5e-464c054321cf", "AQAAAAEAACcQAAAAELO4RrdT7uD2eOcu8rtzh5R7RPJ5O3iq4KKVFed/m55VHc1DH05QL/b4AXy7cnF8lQ==", "d4f0033f-8366-492a-8712-d787b1e6dd72" });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD123",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 41, 24, 315, DateTimeKind.Local).AddTicks(7583), new DateTime(2023, 5, 21, 19, 41, 24, 315, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD234",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 41, 24, 315, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 5, 21, 19, 41, 24, 315, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD345",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 41, 24, 315, DateTimeKind.Local).AddTicks(7645), new DateTime(2023, 5, 21, 20, 41, 24, 315, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Teljesitmenyek",
                keyColumn: "teljesitmenyID",
                keyValue: 2,
                column: "ertekeles",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Teljesitmenyek",
                keyColumn: "teljesitmenyID",
                keyValue: 3,
                column: "ertekeles",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ertekeles",
                table: "Teljesitmenyek");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DFG234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7134b231-c53d-4e59-8083-5174a3fcb083", "AQAAAAEAACcQAAAAEMGy9DZ02Jnlj0rYiXLzWmOqyJp62HUxnAsIv1PxRdflhOcL950YbXCMvezLsbu+vA==", "8446d98e-5a53-404f-b005-5b3423a98181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "QWE234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a26a3acf-6a68-46ae-a9cd-27b4a7bd35ac", "AQAAAAEAACcQAAAAEPvKOQ8TGT8fZP/r5I/gAYhKb2fCFGHfWG5U6kJoohjxG+nM/lt4uz8lKS70phGZPg==", "9063f405-ddfa-4115-a72f-62c9a90f308a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "XY2345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb3a95d-1f3d-41a4-bf7f-8e9b1c8df53c", "AQAAAAEAACcQAAAAELntuInHVS8oQ8LukOCr2MdLRyhmLAyowxxShOc6gxrSZ0CcWKvuIpbzt8uhYMh8Tg==", "74c39723-76b6-4a00-ad53-08b863ec5c4b" });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD123",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 40, 6, 427, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 5, 21, 19, 40, 6, 427, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD234",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 40, 6, 427, DateTimeKind.Local).AddTicks(7132), new DateTime(2023, 5, 21, 19, 40, 6, 427, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Orak",
                keyColumn: "Id",
                keyValue: "ASD345",
                columns: new[] { "oraKezdet", "oraVeg" },
                values: new object[] { new DateTime(2023, 5, 21, 18, 40, 6, 427, DateTimeKind.Local).AddTicks(7140), new DateTime(2023, 5, 21, 20, 40, 6, 427, DateTimeKind.Local).AddTicks(7141) });
        }
    }
}

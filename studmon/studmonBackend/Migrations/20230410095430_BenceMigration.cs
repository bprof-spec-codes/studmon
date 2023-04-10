using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class BenceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3UAW0Q");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "APPB25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CUTH6G");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "5SDJ5O");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8MC285");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "WA6XST");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "06W1O7", 0, "b0311c95-4880-4944-87d5-df2e9dc7eed5", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAENUzDSO3zVdfrI3L1dQ+tpVUUcN3/rG7pjZLSDnLyWh1UkuM3anVCLkaumMBTxAvVA==", null, false, "3b22af81-a84f-4a2e-a565-73786db50c9f", false, "Balogh Attila", "Balogh Attila" },
                    { "1LW2O5", 0, "46da6a48-bb13-4ee4-8e1f-71b049499d22", "tompa.tamas@gmail.com", false, false, null, "TOMPA.TAMAS@GMAIL.COM", "TOMPA.TAMAS@GMAIL.COM", "AQAAAAEAACcQAAAAEM0xl/l5x9ewE9KI6rbOQ8EavbIKeH5unzfccyTxM9vOloyn+R7fQfR+T4CtQjiuXg==", null, false, "8754a556-e0de-41de-90d4-c1c5868bbb78", false, "Tompa Tamás", "Tompa Tamás" },
                    { "3630CT", 0, "04c301e2-8a65-42ad-b96b-bc552b2c7d76", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAELTL1OTFMJB6bVVx05Ft25ImBrRAJx2VCR5sliMneRj90J8qoxVLbMq0OimsDRv6Ug==", null, false, "0ce44787-2608-4bb7-979d-b1cad0bb164d", false, "Tóth Angéla", "Tóth Angéla" },
                    { "K6E7OE", 0, "1214e3b8-fcc8-4ee9-8100-8d247d8cd688", "bator.bela@gmail.com", false, false, null, "BATOR.BELA@GMAIL.COM", "BATOR.BELA@GMAIL.COM", "AQAAAAEAACcQAAAAEC39wCXnQoF4e1LeuzCHLMAt/+b/LXq5EzG2N0d/yEIC+NTzvwXF6c1leZn07ZPk5w==", null, false, "66e5cf0c-bfa1-4693-8dd1-08ff6b6ee642", false, "Bátor Béla", "Bátor Béla" },
                    { "Q3NSXD", 0, "f079f6a6-6e2d-41c7-b6ff-305e11258bc2", "eles.mark@gmail.com", false, false, null, "ELES.MARK@GMAIL.COM", "ELES.MARK@GMAIL.COM", "AQAAAAEAACcQAAAAEJ2SKxItnnP9BL6C4L3fE5mJVuAG8BRzKBtNE8Yd/0qOt1gZZ0wJ5z8yxcavHGG7bA==", null, false, "d36a62b1-9c4a-4760-b0e3-775ec0109356", false, "Éles Márk", "Éles Márk" },
                    { "U781N2", 0, "41c5c221-ee43-446b-afd8-cd2ec4ac23a6", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAELrIWxIStdHyqJMmBDpndyBgHXOZ1SRVfeSa0GwRce+zvf0aYtjUMFDflfOIJLOB9Q==", null, false, "5cda0978-e4be-4fcb-b802-3ae01624ada2", false, "Horváth Károly", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "2083OD", "KGK", "Bsc", "Szabó Pálma" },
                    { "27111O", "NIK", "Bsc", "Török Levente" },
                    { "2P4Q87", "KVK", "Bsc", "Boros ALex" },
                    { "473JMP", "AMK", "Bsc", "Merész Márk" },
                    { "4ICA8S", "AMK", "Bprof", "Sipos Julianna" },
                    { "506E01", "NIK", "Bsc", "Sörös Csaba" },
                    { "T4Y2YP", "NIK", "Bsc", "Nyári Dalma" },
                    { "Y01S61", "NIK", "Bprof", "Huba Árpád" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06W1O7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1LW2O5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3630CT");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "K6E7OE");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Q3NSXD");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "U781N2");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "2083OD");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "27111O");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "2P4Q87");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "473JMP");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "4ICA8S");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "506E01");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "T4Y2YP");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "Y01S61");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "3UAW0Q", 0, "0a1a4c35-af2d-429f-8db2-28e56d1a70a0", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEHVo58EtevdWqgsEaIRKHp2gy9PyfRVQp7GxyyW6uusKUJiP3IY085PRAV3ovE93IQ==", null, false, "5662a758-a3b5-449b-a498-29a89325ebe7", false, "Balogh Attila", "Balogh Attila" },
                    { "APPB25", 0, "8d315dd1-f0ca-43c6-a015-bd8a3ca6633c", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEO/z4Uslmx6rIk2kaIdhOUx+b43uS95eF4uCO8TYeA2U1idaaZlLDiXYDLe4NxGk8Q==", null, false, "be1b8cfa-be24-4ce7-9ebb-d4a52c41a762", false, "Horváth Károly", "Horváth Károly" },
                    { "CUTH6G", 0, "fa5cf722-f814-480c-839b-854354ac6212", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAELp2hjQf7AsBoIJ+WzzBCUbGCh9m4l+ECvl1p2IeQ2UyevvsDbQ6YrmFIFiIC5h6tg==", null, false, "9dfe1feb-fae4-4c80-a386-2e772e35ed4a", false, "Tóth Angéla", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "5SDJ5O", "NIK", "Bsc", "Nyári Dalma" },
                    { "8MC285", "NIK", "Bsc", "Török Levente" },
                    { "WA6XST", "NIK", "Bprof", "Huba Árpád" }
                });
        }
    }
}

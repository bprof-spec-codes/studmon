using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class Bence2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2KG72D", 0, "b874e551-256c-4b3f-b878-55bcd1eab153", "eles.mark@gmail.com", false, false, null, "ELES.MARK@GMAIL.COM", "ELES.MARK@GMAIL.COM", "AQAAAAEAACcQAAAAEC5Ftcg9hQkrmjOhqvTFTqnuxX/buPGWms3/sw0q1eJyiduuoliL0+Jr0QEnVUl0sA==", null, false, "553f5c07-5464-4149-8492-29147ee4025a", false, "Éles Márk", "Éles Márk" },
                    { "555FAG", 0, "dd1ed13e-05c7-4260-b994-019579900a28", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEHZ0cEQppnszYjgcRp1gb+c4ZLzl4BhU/tEQk1fBKE0rNKavOQmfbqV5rurCkBHaQA==", null, false, "ae52cf1c-7bd9-43fe-83b1-98b10c7e03d7", false, "Horváth Károly", "Horváth Károly" },
                    { "66CM5W", 0, "40536741-d5dc-4c1d-9f6f-cf22d21e805a", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEIN0KGuj+mE2U2BR/15Wv9LpFKxanpsJVXDM+5KoqbHZ6ONaE4iUYQyKeojVA/EXxA==", null, false, "d45e35ea-f954-4d88-90ba-392b56883fba", false, "Balogh Attila", "Balogh Attila" },
                    { "I6NP48", 0, "df3a1381-6ce3-49a6-b442-4a5b89aa68ad", "bator.bela@gmail.com", false, false, null, "BATOR.BELA@GMAIL.COM", "BATOR.BELA@GMAIL.COM", "AQAAAAEAACcQAAAAEMXz1uwm8ta0T4y57OjucVhMgaq4Yk79fT8v1wgydyVYwTErKNvMO+BizFJeLSmYgg==", null, false, "d7e2c095-ab80-4bbb-b415-6c35aed207b8", false, "Bátor Béla", "Bátor Béla" },
                    { "KAG50P", 0, "5708f8bd-82c9-48d4-b6c5-b01dcd9df169", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEA9YcwlM78UXkgdizNigWmuW3ZgR1nPbPBlmO9a3hpfaAGhmsHuIswC+W4KD88XnUA==", null, false, "2849833e-44ae-419e-aa3c-1ad3d4c0779b", false, "Tóth Angéla", "Tóth Angéla" },
                    { "S1B0V1", 0, "08e74814-38fb-48de-8425-25af4ab813fa", "safrany.sandor@gmail.com", false, false, null, "SAFRANY.SANDOR@GMAIL.COM", "SAFRANY.SANDOR@GMAIL.COM", "AQAAAAEAACcQAAAAELgHFvGlivSX6jOu5WP9AnJAIaoHPAIa0C0/yIWDthnVRGLGvpV3SnTRmjAUB60GIQ==", null, false, "526282e4-b70e-40c8-8e16-a37ebd62156f", false, "Sáfrány Sándor", "Sáfrány Sándor" },
                    { "TN54JY", 0, "6bfa3f41-50c7-40ed-a09e-4dc10276be71", "tompa.tamas@gmail.com", false, false, null, "TOMPA.TAMAS@GMAIL.COM", "TOMPA.TAMAS@GMAIL.COM", "AQAAAAEAACcQAAAAEOPEQLAhGSjQjrNyeUNPmM9YbmDRUnmtEzWg3fj5A6M4Q9JYcI+uxniQksS/VAs5+A==", null, false, "affd39f9-bb7a-4851-97a6-bc965438250f", false, "Tompa Tamás", "Tompa Tamás" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "10YLRV", "KVK", "Bprof", "Kovács Aladár" },
                    { "18I634", "KGK", "Bsc", "Borsodi Janka" },
                    { "4X6VD5", "NIK", "Bsc", "Nyári Dalma" },
                    { "8R56O8", "KGK", "Bsc", "Szabó Pálma" },
                    { "AGQ86X", "AMK", "Bprof", "Sipos Julianna" },
                    { "ASGC34", "NIK", "Bsc", "Sörös Csaba" },
                    { "F851F1", "NIK", "Bprof", "Huba Árpád" },
                    { "M1677S", "AMK", "Bsc", "Merész Márk" },
                    { "QE7AE7", "NIK", "Bsc", "Török Levente" },
                    { "QRG0TT", "KVK", "Bsc", "Boros ALex" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2KG72D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555FAG");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66CM5W");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "I6NP48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "KAG50P");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "S1B0V1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "TN54JY");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "10YLRV");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "18I634");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "4X6VD5");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "8R56O8");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "AGQ86X");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "ASGC34");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "F851F1");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "M1677S");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "QE7AE7");

            migrationBuilder.DeleteData(
                table: "Hallgatok",
                keyColumn: "neptunKod",
                keyValue: "QRG0TT");

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
    }
}

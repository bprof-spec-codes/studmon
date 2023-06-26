using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class studmon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hallgatok",
                columns: table => new
                {
                    neptunKod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kepzesNev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hallgatok", x => x.neptunKod);
                });

            migrationBuilder.CreateTable(
                name: "Termek",
                columns: table => new
                {
                    nev = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    elrendezes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termek", x => x.nev);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orak",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    leiras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teremID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tanarID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    alkalmakSzama = table.Column<int>(type: "int", nullable: false),
                    oraKezdet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    oraVeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ulesRend = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orak_AspNetUsers_tanarID",
                        column: x => x.tanarID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orak_Termek_teremID",
                        column: x => x.teremID,
                        principalTable: "Termek",
                        principalColumn: "nev",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OraManyToHallgatoMany",
                columns: table => new
                {
                    OraId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HallgatoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OraManyToHallgatoMany", x => new { x.OraId, x.HallgatoId });
                    table.ForeignKey(
                        name: "FK_OraManyToHallgatoMany_Hallgatok_HallgatoId",
                        column: x => x.HallgatoId,
                        principalTable: "Hallgatok",
                        principalColumn: "neptunKod",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OraManyToHallgatoMany_Orak_OraId",
                        column: x => x.OraId,
                        principalTable: "Orak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teljesitmenyek",
                columns: table => new
                {
                    teljesitmenyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hallgatoNeptunKod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    oraId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ertekeles = table.Column<int>(type: "int", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teljesitmenyek", x => x.teljesitmenyID);
                    table.ForeignKey(
                        name: "FK_Teljesitmenyek_Hallgatok_hallgatoNeptunKod",
                        column: x => x.hallgatoNeptunKod,
                        principalTable: "Hallgatok",
                        principalColumn: "neptunKod",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teljesitmenyek_Orak_oraId",
                        column: x => x.oraId,
                        principalTable: "Orak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Tanar", "TANAR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "nev" },
                values: new object[,]
                {
                    { "ADMIN1", 0, "484e56f8-61cd-4d49-95eb-f77a4b70a4f4", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEA3uZPl3Y0lRA0SXLjpC8iDyAcBf7D1Wuv9tN8IdjGTn1BSDLHx5Ruvhn6xHhny8Pw==", null, false, "08ddfc11-596c-477c-a88a-11031e1c1350", false, "admin@gmail.com", "Admin" },
                    { "DFG234", 0, "cdb6b924-8ac2-47b8-8c6a-32d9a9aaa9f1", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEB7Ugeq3U+9YkVAPMFdbo+gHEUvYQg6wb4AiiUlJ9Kj+1QdRxuQynvcBeNETpGPSvQ==", null, false, "dc809c98-957e-4934-959a-56a8bcb1752f", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "QWE234", 0, "92e6c6ac-718c-4061-8f55-1f60c623b043", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAEOI4AfrVkgssERmtjN28kGZEZtjDK9nwd4tTbpjjYgBQipBmBnTufvCEsjAMDyK5ew==", null, false, "92b9cc94-c8bc-4de3-a740-791c56fddce9", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "XY2345", 0, "88b7d6fa-e6a7-4d19-ac3b-183a815a07a4", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEIM98lN+OOehMGSID2+Nhsr4AvScAyp5lyyqTjKlea8eL6C4mnVEEqDdBjZwACdE7A==", null, false, "0c3c869a-5a59-4d5d-9571-694fc595e9c0", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "ABC123", "NIK", "Bsc", "Sörös Csaba" },
                    { "ABC456", "NIK", "Bsc", "Sörös Bence" },
                    { "ERF456", "NIK", "Bsc", "Nyári Dalma" },
                    { "FTG456", "NIK", "Bprof", "Huba Árpád" },
                    { "KJGL45", "NIK", "Bsc", "Török Levente" }
                });

            migrationBuilder.InsertData(
                table: "Termek",
                columns: new[] { "nev", "elrendezes" },
                values: new object[,]
                {
                    { "BA 1.21", "1110111,1110111,1110111,1110111" },
                    { "BA 1.45", "1110111,1110111,1110111,1110111" },
                    { "BA Audmax", "110111,110111,110111,110111" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "ADMIN1" },
                    { "2", "DFG234" },
                    { "2", "QWE234" },
                    { "2", "XY2345" }
                });

            migrationBuilder.InsertData(
                table: "Orak",
                columns: new[] { "Id", "alkalmakSzama", "leiras", "nev", "oraKezdet", "oraVeg", "tanarID", "teremID", "ulesRend" },
                values: new object[] { "ASD345", 11, "hft", "Vállgazd", new DateTime(2023, 6, 13, 18, 37, 54, 992, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 6, 13, 20, 37, 54, 992, DateTimeKind.Local).AddTicks(7973), "DFG234", "BA Audmax", "ERF456 FTG456 @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @" });

            migrationBuilder.InsertData(
                table: "OraManyToHallgatoMany",
                columns: new[] { "HallgatoId", "OraId", "ID" },
                values: new object[,]
                {
                    { "ERF456", "ASD345", 1 },
                    { "FTG456", "ASD345", 2 }
                });

            migrationBuilder.InsertData(
                table: "Teljesitmenyek",
                columns: new[] { "teljesitmenyID", "WeekNumber", "ertekeles", "hallgatoNeptunKod", "oraId" },
                values: new object[,]
                {
                    { 1, 1, 0, "FTG456", "ASD345" },
                    { 2, 2, -1, "FTG456", "ASD345" },
                    { 3, 3, 1, "FTG456", "ASD345" },
                    { 4, 1, 1, "ERF456", "ASD345" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orak_tanarID",
                table: "Orak",
                column: "tanarID");

            migrationBuilder.CreateIndex(
                name: "IX_Orak_teremID",
                table: "Orak",
                column: "teremID");

            migrationBuilder.CreateIndex(
                name: "IX_OraManyToHallgatoMany_HallgatoId",
                table: "OraManyToHallgatoMany",
                column: "HallgatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Teljesitmenyek_hallgatoNeptunKod",
                table: "Teljesitmenyek",
                column: "hallgatoNeptunKod");

            migrationBuilder.CreateIndex(
                name: "IX_Teljesitmenyek_oraId",
                table: "Teljesitmenyek",
                column: "oraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OraManyToHallgatoMany");

            migrationBuilder.DropTable(
                name: "Teljesitmenyek");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Hallgatok");

            migrationBuilder.DropTable(
                name: "Orak");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Termek");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class teszt : Migration
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
                    { "DFG234", 0, "2a5e838d-c67a-4c56-a420-f2e01cdb2a2a", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAECnkbHM7qbiYTPWfdpj3Dh9TLq77+iKSQdNWntkKcKRoZUTU6h5Knzt/gkYdFUs52w==", null, false, "6b435961-c484-4475-b602-3ff6a85029d5", false, "toth.angela@gmail.com", "Tóth Angéla" },
                    { "QWE234", 0, "043c7416-530b-4214-b4a1-3e85e19718ed", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAED150I8MF5f2alLuhp+1AttjFFEkysrdt3Ide7tk/qKzNvJyw06UFreJXUfti/V/DA==", null, false, "514f5418-ae2b-48c5-bb93-62ec033a3d60", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "XY2345", 0, "562658cc-d3e9-4c86-a4f7-bd9cf1ae1b93", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEKtvrg+mwz8owEWXMjhrJxm7eWj2lFSxacPUKv07cO4TmG5EoVErlLn8WWu28Nl2Ug==", null, false, "84911a7b-94d7-41ac-b31b-c141449866f7", false, "horvat.karoly@gmail.com", "Horváth Károly" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
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
                    { "2", "DFG234" },
                    { "2", "QWE234" },
                    { "2", "XY2345" }
                });

            migrationBuilder.InsertData(
                table: "Orak",
                columns: new[] { "Id", "alkalmakSzama", "leiras", "nev", "oraKezdet", "oraVeg", "tanarID", "teremID", "ulesRend" },
                values: new object[,]
                {
                    { "ASD123", 12, "hft", "HFT", new DateTime(2023, 5, 27, 15, 50, 52, 244, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 5, 27, 16, 50, 52, 244, DateTimeKind.Local).AddTicks(3513), "XY2345", "BA 1.45", "" },
                    { "ASD234", 13, "dimat1", "Dimat1", new DateTime(2023, 5, 27, 15, 50, 52, 244, DateTimeKind.Local).AddTicks(3531), new DateTime(2023, 5, 27, 16, 50, 52, 244, DateTimeKind.Local).AddTicks(3533), "QWE234", "BA 1.45", "" },
                    { "ASD345", 11, "hft", "Vállgazd", new DateTime(2023, 5, 27, 15, 50, 52, 244, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 5, 27, 17, 50, 52, 244, DateTimeKind.Local).AddTicks(3540), "DFG234", "BA Audmax", "" }
                });

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

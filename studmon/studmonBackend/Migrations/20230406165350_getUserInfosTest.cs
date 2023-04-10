using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class getUserInfosTest : Migration
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
                    HallgatoId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    teljesitmenyID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hallgatoNeptunKod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    oraId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

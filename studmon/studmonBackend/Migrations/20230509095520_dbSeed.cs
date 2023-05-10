using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studmonBackend.Migrations
{
    public partial class dbSeed : Migration
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
                    { "CK6482", 0, "ca7e52e6-2d9c-4f6c-b78f-ee723b03f0b8", "horvat.karoly@gmail.com", false, false, null, "HORVAT.KAROLY@GMAIL.COM", "HORVAT.KAROLY@GMAIL.COM", "AQAAAAEAACcQAAAAEBp69SiMvtpyEITF01o6JOC21MCYipflGeQeJ1wB5W4hP8l8+PNL1u56F6iG5FqG2g==", null, false, "7aa79ea1-4375-4040-8f94-63292b10ed5d", false, "horvat.karoly@gmail.com", "Horváth Károly" },
                    { "GPMFSV", 0, "dc2a0574-4c88-4016-b94f-d2a0938dbbd9", "balogh.attila@gmail.com", false, false, null, "BALOGH.ATTILA@GMAIL.COM", "BALOGH.ATTILA@GMAIL.COM", "AQAAAAEAACcQAAAAENR079tl4hkiSmw7hzeXGdOW3faP9tnZxtxfkF/m8QaYynXRMp2DmEcU5BTLitgTIg==", null, false, "a775b724-8232-44cb-968c-85a9054e3daa", false, "balogh.attila@gmail.com", "Balogh Attila" },
                    { "WMH4Y7", 0, "7d7e5c5f-fac0-4c7f-b729-dd7d772e1b15", "toth.angela@gmail.com", false, false, null, "TOTH.ANGELA@GMAIL.COM", "TOTH.ANGELA@GMAIL.COM", "AQAAAAEAACcQAAAAEL2al8H7UqT91idPkYLZmCRQvUnEEJtuxzpR3qhrBw3EPMYscfzYP0jBB0PEDa0bNw==", null, false, "8a16a071-c238-4bc6-8a88-39cb8588a811", false, "toth.angela@gmail.com", "Tóth Angéla" }
                });

            migrationBuilder.InsertData(
                table: "Hallgatok",
                columns: new[] { "neptunKod", "kar", "kepzesNev", "nev" },
                values: new object[,]
                {
                    { "CQQ00K", "NIK", "Bsc", "Török Levente" },
                    { "EBT3WA", "NIK", "Bsc", "Nyári Dalma" },
                    { "Y2R34Y", "NIK", "Bprof", "Huba Árpád" }
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

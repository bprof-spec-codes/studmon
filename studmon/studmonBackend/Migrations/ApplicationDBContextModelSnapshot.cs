﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using studmonBackend.Data.DBContext;

#nullable disable

namespace studmonBackend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Tanar",
                            NormalizedName = "TANAR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "DFG234",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "QWE234",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "XY2345",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Hallgato", b =>
                {
                    b.Property<string>("neptunKod")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("kar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kepzesNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("neptunKod");

                    b.ToTable("Hallgatok");

                    b.HasData(
                        new
                        {
                            neptunKod = "FTG456",
                            kar = "NIK",
                            kepzesNev = "Bprof",
                            nev = "Huba Árpád"
                        },
                        new
                        {
                            neptunKod = "KJGL45",
                            kar = "NIK",
                            kepzesNev = "Bsc",
                            nev = "Török Levente"
                        },
                        new
                        {
                            neptunKod = "ERF456",
                            kar = "NIK",
                            kepzesNev = "Bsc",
                            nev = "Nyári Dalma"
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.ManyToManyModels.OraManyToHallgatoMany", b =>
                {
                    b.Property<string>("OraId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HallgatoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.HasKey("OraId", "HallgatoId");

                    b.HasIndex("HallgatoId");

                    b.ToTable("OraManyToHallgatoMany");

                    b.HasData(
                        new
                        {
                            OraId = "ASD123",
                            HallgatoId = "FTG456",
                            ID = 1
                        },
                        new
                        {
                            OraId = "ASD345",
                            HallgatoId = "FTG456",
                            ID = 2
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Ora", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("alkalmakSzama")
                        .HasColumnType("int");

                    b.Property<string>("leiras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("oraKezdet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("oraVeg")
                        .HasColumnType("datetime2");

                    b.Property<string>("tanarID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("teremID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ulesRend")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("tanarID");

                    b.HasIndex("teremID");

                    b.ToTable("Orak");

                    b.HasData(
                        new
                        {
                            Id = "ASD123",
                            alkalmakSzama = 12,
                            leiras = "hft",
                            nev = "HFT",
                            oraKezdet = new DateTime(2023, 5, 23, 14, 57, 15, 778, DateTimeKind.Local).AddTicks(2316),
                            oraVeg = new DateTime(2023, 5, 23, 15, 57, 15, 778, DateTimeKind.Local).AddTicks(2350),
                            tanarID = "XY2345",
                            teremID = "BA 1.45",
                            ulesRend = ""
                        },
                        new
                        {
                            Id = "ASD234",
                            alkalmakSzama = 13,
                            leiras = "dimat1",
                            nev = "Dimat1",
                            oraKezdet = new DateTime(2023, 5, 23, 14, 57, 15, 778, DateTimeKind.Local).AddTicks(2367),
                            oraVeg = new DateTime(2023, 5, 23, 15, 57, 15, 778, DateTimeKind.Local).AddTicks(2369),
                            tanarID = "QWE234",
                            teremID = "BA 1.45",
                            ulesRend = ""
                        },
                        new
                        {
                            Id = "ASD345",
                            alkalmakSzama = 11,
                            leiras = "hft",
                            nev = "Vállgazd",
                            oraKezdet = new DateTime(2023, 5, 23, 14, 57, 15, 778, DateTimeKind.Local).AddTicks(2374),
                            oraVeg = new DateTime(2023, 5, 23, 16, 57, 15, 778, DateTimeKind.Local).AddTicks(2375),
                            tanarID = "DFG234",
                            teremID = "BA Audmax",
                            ulesRend = ""
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Tanar", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "DFG234",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64109d36-e0fc-4337-bfbb-2195f34c0793",
                            Email = "toth.angela@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TOTH.ANGELA@GMAIL.COM",
                            NormalizedUserName = "TOTH.ANGELA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKgEchJFq5KvllddqmgxS9DbSOYyaioi/gKD7xJwCP+xgB6lAbf6rHjGGLRbcZim4A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8a0b8c87-2431-48e9-80ff-14ba2959a823",
                            TwoFactorEnabled = false,
                            UserName = "toth.angela@gmail.com",
                            nev = "Tóth Angéla"
                        },
                        new
                        {
                            Id = "QWE234",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a948857-e26b-4a0d-9fd2-edc422479e9b",
                            Email = "balogh.attila@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BALOGH.ATTILA@GMAIL.COM",
                            NormalizedUserName = "BALOGH.ATTILA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEF52Pv6QUpWNF4BrIYZp9SVN+DGPc5qTdaxwRdM2OYyons9BDdUbAAivNJD/ws+qUw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a54c0740-bcd8-4312-a03f-8053a06c5848",
                            TwoFactorEnabled = false,
                            UserName = "balogh.attila@gmail.com",
                            nev = "Balogh Attila"
                        },
                        new
                        {
                            Id = "XY2345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "772ebb6c-ca32-441c-ae49-836efa7263bf",
                            Email = "horvat.karoly@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HORVAT.KAROLY@GMAIL.COM",
                            NormalizedUserName = "HORVAT.KAROLY@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAIV1aBBGnKhbmXEzpIgO4ifwQoL1f08/g7dVjG/sPq8OmVLUMXJphN1peRN8D2YbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4dc4a60c-afad-4292-abdb-e9ad73c8a03f",
                            TwoFactorEnabled = false,
                            UserName = "horvat.karoly@gmail.com",
                            nev = "Horváth Károly"
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Teljesitmeny", b =>
                {
                    b.Property<int>("teljesitmenyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teljesitmenyID"), 1L, 1);

                    b.Property<int>("ertekeles")
                        .HasColumnType("int");

                    b.Property<string>("hallgatoNeptunKod")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("oraId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("teljesitmenyID");

                    b.HasIndex("hallgatoNeptunKod");

                    b.HasIndex("oraId");

                    b.ToTable("Teljesitmenyek");

                    b.HasData(
                        new
                        {
                            teljesitmenyID = 1,
                            ertekeles = 0,
                            hallgatoNeptunKod = "KJGL45",
                            oraId = "ASD234"
                        },
                        new
                        {
                            teljesitmenyID = 2,
                            ertekeles = -1,
                            hallgatoNeptunKod = "KJGL45",
                            oraId = "ASD234"
                        },
                        new
                        {
                            teljesitmenyID = 3,
                            ertekeles = 1,
                            hallgatoNeptunKod = "KJGL45",
                            oraId = "ASD234"
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Terem", b =>
                {
                    b.Property<string>("nev")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("elrendezes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("nev");

                    b.ToTable("Termek");

                    b.HasData(
                        new
                        {
                            nev = "BA 1.45",
                            elrendezes = "1110111,1110111,1110111,1110111"
                        },
                        new
                        {
                            nev = "BA Audmax",
                            elrendezes = "110111,110111,110111,110111"
                        },
                        new
                        {
                            nev = "BA 1.21",
                            elrendezes = "1110111,1110111,1110111,1110111"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Tanar", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Tanar", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("studmonBackend.Data.Models.Tanar", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Tanar", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("studmonBackend.Data.Models.ManyToManyModels.OraManyToHallgatoMany", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Hallgato", "Hallgato")
                        .WithMany("orak")
                        .HasForeignKey("HallgatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("studmonBackend.Data.Models.Ora", "Ora")
                        .WithMany("hallgatokColl")
                        .HasForeignKey("OraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hallgato");

                    b.Navigation("Ora");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Ora", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Tanar", "tanar")
                        .WithMany("orakColl")
                        .HasForeignKey("tanarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("studmonBackend.Data.Models.Terem", "terem")
                        .WithMany("Orak")
                        .HasForeignKey("teremID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tanar");

                    b.Navigation("terem");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Teljesitmeny", b =>
                {
                    b.HasOne("studmonBackend.Data.Models.Hallgato", "hallgato")
                        .WithMany("teljesitmeny")
                        .HasForeignKey("hallgatoNeptunKod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("studmonBackend.Data.Models.Ora", "ora")
                        .WithMany("teljesitmenyColl")
                        .HasForeignKey("oraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hallgato");

                    b.Navigation("ora");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Hallgato", b =>
                {
                    b.Navigation("orak");

                    b.Navigation("teljesitmeny");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Ora", b =>
                {
                    b.Navigation("hallgatokColl");

                    b.Navigation("teljesitmenyColl");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Tanar", b =>
                {
                    b.Navigation("orakColl");
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Terem", b =>
                {
                    b.Navigation("Orak");
                });
#pragma warning restore 612, 618
        }
    }
}

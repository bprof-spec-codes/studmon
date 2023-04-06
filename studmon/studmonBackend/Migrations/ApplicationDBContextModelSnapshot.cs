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
                            neptunKod = "5VDK00",
                            kar = "NIK",
                            kepzesNev = "Bprof",
                            nev = "Huba Árpád"
                        },
                        new
                        {
                            neptunKod = "84167Q",
                            kar = "NIK",
                            kepzesNev = "Bsc",
                            nev = "Török Levente"
                        },
                        new
                        {
                            neptunKod = "RY15SY",
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

                    b.HasKey("OraId", "HallgatoId");

                    b.HasIndex("HallgatoId");

                    b.ToTable("OraManyToHallgatoMany");
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
                            Id = "71P25C",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d87c951a-3b36-41f1-aa19-dc1acec78052",
                            Email = "toth.angela@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TOTH.ANGELA@GMAIL.COM",
                            NormalizedUserName = "TOTH.ANGELA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMR6oXpGQZT9jGussRYnJamdpxZuPnXLaqwAZlKC7aaGcATWIfEXwTbqoNVLl0rs4w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f5c3460e-7b92-4e05-86c4-77dfededa78d",
                            TwoFactorEnabled = false,
                            UserName = "toth.angela@gmail.com",
                            nev = "Tóth Angéla"
                        },
                        new
                        {
                            Id = "EQ702S",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dbbb1050-02a8-4800-aec6-9612b547970c",
                            Email = "balogh.attila@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BALOGH.ATTILA@GMAIL.COM",
                            NormalizedUserName = "BALOGH.ATTILA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEXEOD8QIt/4Z/GSioKUucp5UWpWZtEjGQYfOB5M8aC17tATym6HofHCpsvQu66qLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f3cca9e8-7c0c-48d8-bff2-55b11419e69f",
                            TwoFactorEnabled = false,
                            UserName = "balogh.attila@gmail.com",
                            nev = "Balogh Attila"
                        },
                        new
                        {
                            Id = "4O3N2O",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d2a4b9a2-c8ea-4fad-a9de-861d7c5a3bad",
                            Email = "horvat.karoly@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HORVAT.KAROLY@GMAIL.COM",
                            NormalizedUserName = "HORVAT.KAROLY@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAPaVOCwb3WybaDZ90O6A7OZDwGM4rrKA66XTVC2adKBoLiMBZUEHHmVTt8VXJkSCQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f18382db-1e40-45e8-b5f9-85a39e1feacc",
                            TwoFactorEnabled = false,
                            UserName = "horvat.karoly@gmail.com",
                            nev = "Horváth Károly"
                        });
                });

            modelBuilder.Entity("studmonBackend.Data.Models.Teljesitmeny", b =>
                {
                    b.Property<string>("teljesitmenyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

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

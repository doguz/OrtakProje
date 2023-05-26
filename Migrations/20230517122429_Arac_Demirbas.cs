using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje.Migrations
{
    public partial class Arac_Demirbas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aracAidiyet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aidiyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracAidiyet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracMarka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracMarka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracVitesTipi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vites = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracVitesTipi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracYakit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yakit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracYakit", x => x.Id);
                });

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
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "buro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuroAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinaryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TripleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "demirbasCins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cinsi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demirbasCins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "demirbasMarka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demirbasMarka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "renk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rengi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_renk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rutbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutbeAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rutbe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aracModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracMarkaId = table.Column<int>(type: "int", nullable: false),
                    AracKategoriId = table.Column<int>(type: "int", nullable: false),
                    Detay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aracModel_aracKategori_AracKategoriId",
                        column: x => x.AracKategoriId,
                        principalTable: "aracKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aracModel_aracMarka_AracMarkaId",
                        column: x => x.AracMarkaId,
                        principalTable: "aracMarka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "demirbasModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemirbasMarkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demirbasModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_demirbasModel_demirbasMarka_DemirbasMarkaId",
                        column: x => x.DemirbasMarkaId,
                        principalTable: "demirbasMarka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personel",
                columns: table => new
                {
                    Sicil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    RutbeID = table.Column<int>(type: "int", nullable: false),
                    BuroId = table.Column<int>(type: "int", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personel", x => x.Sicil);
                    table.ForeignKey(
                        name: "FK_personel_buro_BuroId",
                        column: x => x.BuroId,
                        principalTable: "buro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personel_rutbe_RutbeID",
                        column: x => x.RutbeID,
                        principalTable: "rutbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "arac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResmiPlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuayeneTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kilometre = table.Column<int>(type: "int", nullable: true),
                    AracModelId = table.Column<int>(type: "int", nullable: true),
                    AracVitesTipiId = table.Column<int>(type: "int", nullable: true),
                    AracYakitId = table.Column<int>(type: "int", nullable: true),
                    AracAidiyetId = table.Column<int>(type: "int", nullable: true),
                    RenkId = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_arac_aracAidiyet_AracAidiyetId",
                        column: x => x.AracAidiyetId,
                        principalTable: "aracAidiyet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_arac_aracModel_AracModelId",
                        column: x => x.AracModelId,
                        principalTable: "aracModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_arac_aracVitesTipi_AracVitesTipiId",
                        column: x => x.AracVitesTipiId,
                        principalTable: "aracVitesTipi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_arac_aracYakit_AracYakitId",
                        column: x => x.AracYakitId,
                        principalTable: "aracYakit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_arac_renk_RenkId",
                        column: x => x.RenkId,
                        principalTable: "renk",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    TownID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.TownID);
                    table.ForeignKey(
                        name: "FK_Town_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "demirbas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemirbasModelId = table.Column<int>(type: "int", nullable: false),
                    DemirbasCinsiId = table.Column<int>(type: "int", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demirbas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_demirbas_demirbasCins_DemirbasCinsiId",
                        column: x => x.DemirbasCinsiId,
                        principalTable: "demirbasCins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_demirbas_demirbasModel_DemirbasModelId",
                        column: x => x.DemirbasModelId,
                        principalTable: "demirbasModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aracBakim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kilometre = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    PersonelSicil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracBakim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aracBakim_arac_AracId",
                        column: x => x.AracId,
                        principalTable: "arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aracBakim_personel_PersonelSicil",
                        column: x => x.PersonelSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aracKaza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarihSaat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    PersonelSicil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracKaza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aracKaza_arac_AracId",
                        column: x => x.AracId,
                        principalTable: "arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aracKaza_personel_PersonelSicil",
                        column: x => x.PersonelSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aracSivilPlaka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    SivilPlaka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracSivilPlaka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aracSivilPlaka_arac_AracId",
                        column: x => x.AracId,
                        principalTable: "arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aracZimmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AracTeslimSicil = table.Column<int>(type: "int", nullable: true),
                    AracTesellumSicil = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracZimmet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_aracZimmet_arac_AracId",
                        column: x => x.AracId,
                        principalTable: "arac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_aracZimmet_personel_AracTesellumSicil",
                        column: x => x.AracTesellumSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil");
                    table.ForeignKey(
                        name: "FK_aracZimmet_personel_AracTeslimSicil",
                        column: x => x.AracTeslimSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil");
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownID = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_District_Town_TownID",
                        column: x => x.TownID,
                        principalTable: "Town",
                        principalColumn: "TownID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "demirbasZimmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemirbasId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemirbasTeslimSicil = table.Column<int>(type: "int", nullable: false),
                    DemirbasTesellumSicil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demirbasZimmet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_demirbasZimmet_demirbas_DemirbasId",
                        column: x => x.DemirbasId,
                        principalTable: "demirbas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_demirbasZimmet_personel_DemirbasTesellumSicil",
                        column: x => x.DemirbasTesellumSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil");
                    table.ForeignKey(
                        name: "FK_demirbasZimmet_personel_DemirbasTeslimSicil",
                        column: x => x.DemirbasTeslimSicil,
                        principalTable: "personel",
                        principalColumn: "Sicil");
                });

            migrationBuilder.CreateTable(
                name: "Neighborhood",
                columns: table => new
                {
                    NeighborhoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhood", x => x.NeighborhoodID);
                    table.ForeignKey(
                        name: "FK_Neighborhood_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_arac_AracAidiyetId",
                table: "arac",
                column: "AracAidiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_arac_AracModelId",
                table: "arac",
                column: "AracModelId");

            migrationBuilder.CreateIndex(
                name: "IX_arac_AracVitesTipiId",
                table: "arac",
                column: "AracVitesTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_arac_AracYakitId",
                table: "arac",
                column: "AracYakitId");

            migrationBuilder.CreateIndex(
                name: "IX_arac_RenkId",
                table: "arac",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_aracBakim_AracId",
                table: "aracBakim",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_aracBakim_PersonelSicil",
                table: "aracBakim",
                column: "PersonelSicil");

            migrationBuilder.CreateIndex(
                name: "IX_aracKaza_AracId",
                table: "aracKaza",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_aracKaza_PersonelSicil",
                table: "aracKaza",
                column: "PersonelSicil");

            migrationBuilder.CreateIndex(
                name: "IX_aracModel_AracKategoriId",
                table: "aracModel",
                column: "AracKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_aracModel_AracMarkaId",
                table: "aracModel",
                column: "AracMarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_aracSivilPlaka_AracId",
                table: "aracSivilPlaka",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_aracZimmet_AracId",
                table: "aracZimmet",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_aracZimmet_AracTesellumSicil",
                table: "aracZimmet",
                column: "AracTesellumSicil");

            migrationBuilder.CreateIndex(
                name: "IX_aracZimmet_AracTeslimSicil",
                table: "aracZimmet",
                column: "AracTeslimSicil");

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
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_demirbas_DemirbasCinsiId",
                table: "demirbas",
                column: "DemirbasCinsiId");

            migrationBuilder.CreateIndex(
                name: "IX_demirbas_DemirbasModelId",
                table: "demirbas",
                column: "DemirbasModelId");

            migrationBuilder.CreateIndex(
                name: "IX_demirbasModel_DemirbasMarkaId",
                table: "demirbasModel",
                column: "DemirbasMarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_demirbasZimmet_DemirbasId",
                table: "demirbasZimmet",
                column: "DemirbasId");

            migrationBuilder.CreateIndex(
                name: "IX_demirbasZimmet_DemirbasTesellumSicil",
                table: "demirbasZimmet",
                column: "DemirbasTesellumSicil");

            migrationBuilder.CreateIndex(
                name: "IX_demirbasZimmet_DemirbasTeslimSicil",
                table: "demirbasZimmet",
                column: "DemirbasTeslimSicil");

            migrationBuilder.CreateIndex(
                name: "IX_District_TownID",
                table: "District",
                column: "TownID");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhood_DistrictID",
                table: "Neighborhood",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_personel_BuroId",
                table: "personel",
                column: "BuroId");

            migrationBuilder.CreateIndex(
                name: "IX_personel_RutbeID",
                table: "personel",
                column: "RutbeID");

            migrationBuilder.CreateIndex(
                name: "IX_Town_CityID",
                table: "Town",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aracBakim");

            migrationBuilder.DropTable(
                name: "aracKaza");

            migrationBuilder.DropTable(
                name: "aracSivilPlaka");

            migrationBuilder.DropTable(
                name: "aracZimmet");

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
                name: "demirbasZimmet");

            migrationBuilder.DropTable(
                name: "Neighborhood");

            migrationBuilder.DropTable(
                name: "resimler");

            migrationBuilder.DropTable(
                name: "arac");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "demirbas");

            migrationBuilder.DropTable(
                name: "personel");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "aracAidiyet");

            migrationBuilder.DropTable(
                name: "aracModel");

            migrationBuilder.DropTable(
                name: "aracVitesTipi");

            migrationBuilder.DropTable(
                name: "aracYakit");

            migrationBuilder.DropTable(
                name: "renk");

            migrationBuilder.DropTable(
                name: "demirbasCins");

            migrationBuilder.DropTable(
                name: "demirbasModel");

            migrationBuilder.DropTable(
                name: "buro");

            migrationBuilder.DropTable(
                name: "rutbe");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "aracKategori");

            migrationBuilder.DropTable(
                name: "aracMarka");

            migrationBuilder.DropTable(
                name: "demirbasMarka");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}

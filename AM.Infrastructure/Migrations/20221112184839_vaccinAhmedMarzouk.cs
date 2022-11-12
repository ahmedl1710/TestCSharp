using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class vaccinAhmedMarzouk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "centredevaccination",
                columns: table => new
                {
                    centreVaccinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacite = table.Column<int>(type: "int", nullable: false),
                    nbChaises = table.Column<int>(type: "int", nullable: false),
                    numTelephone = table.Column<int>(type: "int", nullable: false),
                    responsableCnetre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_centredevaccination", x => x.centreVaccinationId);
                });

            migrationBuilder.CreateTable(
                name: "citoyen",
                columns: table => new
                {
                    cin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    adresse_codePostal = table.Column<int>(type: "int", nullable: true),
                    adresse_rue = table.Column<int>(type: "int", nullable: true),
                    adresse_ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    citoyenId = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroEvax = table.Column<int>(type: "int", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citoyen", x => x.cin);
                });

            migrationBuilder.CreateTable(
                name: "vaccin",
                columns: table => new
                {
                    vaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateValidite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fournisseur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantite = table.Column<int>(type: "int", nullable: false),
                    typevaccin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccin", x => x.vaccinId);
                });

            migrationBuilder.CreateTable(
                name: "rendezvous",
                columns: table => new
                {
                    dateVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    citoyenId = table.Column<int>(type: "int", nullable: false),
                    vaccinId = table.Column<int>(type: "int", nullable: false),
                    CodeInfermerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nbeDoses = table.Column<int>(type: "int", nullable: false),
                    citoyencin = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rendezvous", x => new { x.vaccinId, x.citoyenId, x.dateVaccination });
                    table.ForeignKey(
                        name: "FK_rendezvous_citoyen_citoyencin",
                        column: x => x.citoyencin,
                        principalTable: "citoyen",
                        principalColumn: "cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rendezvous_vaccin_vaccinId",
                        column: x => x.vaccinId,
                        principalTable: "vaccin",
                        principalColumn: "vaccinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rendezvous_citoyencin",
                table: "rendezvous",
                column: "citoyencin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "centredevaccination");

            migrationBuilder.DropTable(
                name: "rendezvous");

            migrationBuilder.DropTable(
                name: "citoyen");

            migrationBuilder.DropTable(
                name: "vaccin");
        }
    }
}

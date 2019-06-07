using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pharmacy.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenericMedicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericMedicaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PharmacyLicense = table.Column<string>(nullable: true),
                    DrugsLicense = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugMedicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TradeName = table.Column<string>(nullable: true),
                    GenericId = table.Column<int>(nullable: false),
                    Measure = table.Column<string>(nullable: true),
                    PackingContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugMedicaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugMedicaments_GenericMedicaments_GenericId",
                        column: x => x.GenericId,
                        principalTable: "GenericMedicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedAndSoldDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PharmacyId = table.Column<int>(nullable: false),
                    DrugId = table.Column<int>(nullable: true),
                    DrugMendicamentId = table.Column<int>(nullable: false),
                    ReportingPeriod = table.Column<int>(nullable: false),
                    AvailabilityAtTheBeginning = table.Column<int>(nullable: false),
                    PurchasedQuantity = table.Column<int>(nullable: false),
                    SoldQuantity = table.Column<int>(nullable: false),
                    AvailabilityAtTheEnd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedAndSoldDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedAndSoldDrugs_DrugMedicaments_DrugId",
                        column: x => x.DrugId,
                        principalTable: "DrugMedicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchasedAndSoldDrugs_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugMedicaments_GenericId",
                table: "DrugMedicaments",
                column: "GenericId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedAndSoldDrugs_DrugId",
                table: "PurchasedAndSoldDrugs",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedAndSoldDrugs_PharmacyId",
                table: "PurchasedAndSoldDrugs",
                column: "PharmacyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchasedAndSoldDrugs");

            migrationBuilder.DropTable(
                name: "DrugMedicaments");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "GenericMedicaments");
        }
    }
}

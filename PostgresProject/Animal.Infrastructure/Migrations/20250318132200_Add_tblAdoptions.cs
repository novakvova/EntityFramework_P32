using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Animal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_tblAdoptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAdoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnimalId = table.Column<int>(type: "integer", nullable: false),
                    AdopterId = table.Column<int>(type: "integer", nullable: false),
                    AdoptedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblAdoptions_tblAdopters_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "tblAdopters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAdoptions_tbl_animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "tbl_animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAdoptions_AdopterId",
                table: "tblAdoptions",
                column: "AdopterId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAdoptions_AnimalId",
                table: "tblAdoptions",
                column: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAdoptions");
        }
    }
}

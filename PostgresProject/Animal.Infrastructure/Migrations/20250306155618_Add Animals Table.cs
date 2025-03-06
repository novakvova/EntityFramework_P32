using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Animal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SpecieId = table.Column<int>(type: "integer", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(40000)", maxLength: 40000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_animals_tbl_species_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "tbl_species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_animals_SpecieId",
                table: "tbl_animals",
                column: "SpecieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_animals");
        }
    }
}

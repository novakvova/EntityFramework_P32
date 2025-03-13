using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_ForeignKey_Animal_Shelter_Locations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShelterLocationId",
                table: "tbl_animals",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_animals_ShelterLocationId",
                table: "tbl_animals",
                column: "ShelterLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_animals_tbl_shelter_locations_ShelterLocationId",
                table: "tbl_animals",
                column: "ShelterLocationId",
                principalTable: "tbl_shelter_locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_animals_tbl_shelter_locations_ShelterLocationId",
                table: "tbl_animals");

            migrationBuilder.DropIndex(
                name: "IX_tbl_animals_ShelterLocationId",
                table: "tbl_animals");

            migrationBuilder.DropColumn(
                name: "ShelterLocationId",
                table: "tbl_animals");
        }
    }
}

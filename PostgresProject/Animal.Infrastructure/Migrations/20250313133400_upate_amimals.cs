using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class upate_amimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "ArrivalDate",
                table: "tbl_animals",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "tbl_animals",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tbl_animals",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "tbl_animals");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "tbl_animals");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tbl_animals");
        }
    }
}

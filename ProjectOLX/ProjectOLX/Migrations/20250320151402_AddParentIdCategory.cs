using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOLX.Migrations
{
    /// <inheritdoc />
    public partial class AddParentIdCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ParentId",
                table: "tblCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCategories_ParentId",
                table: "tblCategories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCategories_tblCategories_ParentId",
                table: "tblCategories",
                column: "ParentId",
                principalTable: "tblCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCategories_tblCategories_ParentId",
                table: "tblCategories");

            migrationBuilder.DropIndex(
                name: "IX_tblCategories_ParentId",
                table: "tblCategories");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "tblCategories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.SimpleSQLite.Migrations
{
    /// <inheritdoc />
    public partial class Add_tbl_categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 40000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_categories");
        }
    }
}
